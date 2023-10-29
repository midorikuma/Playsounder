using CSCore;
using CSCore.SoundOut;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NVorbis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace Playsounder
{

    public partial class Form1 : Form, IDisposable
    {
        private JObject soundsJson;

        public class NvorbisToCSCore : IWaveSource, IDisposable
        {
            public bool CanSeek => true;

            private VorbisReader _reader;
            private WaveFormat _waveFormat;

            public NvorbisToCSCore(string filename)
            {
                _reader = new VorbisReader(filename);
                _waveFormat = new WaveFormat(_reader.SampleRate, 16, _reader.Channels);
            }

            public int Read(byte[] buffer, int offset, int count)
            {
                var samplesRequired = count / 2; // because of 16bit samples
                var floatBuffer = new float[samplesRequired];
                var samplesRead = _reader.ReadSamples(floatBuffer, 0, samplesRequired);

                var bytesWritten = 0;
                for (int i = 0; i < samplesRead; i++)
                {
                    var temp = (short)(floatBuffer[i] * short.MaxValue);
                    buffer[offset + bytesWritten++] = (byte)(temp & 0xff);
                    buffer[offset + bytesWritten++] = (byte)(temp >> 8);
                }

                return bytesWritten;
            }

            public WaveFormat WaveFormat => _waveFormat;
            public long Position
            {
                get => _reader.SamplePosition;
                set => _reader.SamplePosition = value;
            }
            public long Length => _reader.TotalSamples * _waveFormat.Channels;

            // IDisposableの実装
            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
            }

            protected virtual void Dispose(bool disposing)
            {
                if (disposing)
                {
                    // Managed resourcesの解放
                    _reader?.Dispose();
                    _reader = null;
                }
                // Unmanaged resourcesの解放
            }

            // ファイナライザ（デストラクタ）
            ~NvorbisToCSCore()
            {
                Dispose(false);
            }
        }

        public struct data
        {
            public string FullPath;
            public string Hash;
        }
        public static List<data> Sounds = new List<data>();
        public static List<string> FullPaths = new List<string>();
        public static string RootPath =
            System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\";
        //複数oggの数字検索用
        public static Random rnd = new System.Random();
        public static string PlayHash;
        public static bool PlayMute = false;
        public static float PlayVolume = 1.0f;
        public static float PlaySpeed = 1.0f;
        public static float BarSpeed = 1.0f;
        public static int handle;



        public Form1()
        {
            InitializeComponent();
        }

        void comboBox1_OnDropDownOpened(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();

            string launcherProfilesPath = RootPath + "launcher_profiles.json";
            string versionsDir = RootPath + @"versions\";

            // versionsディレクトリから最新のversion_manifestファイルを取得
            var versionManifestFiles = Directory.GetFiles(versionsDir, "version_manifest_v*.json");
            var latestVersionManifest = versionManifestFiles.OrderByDescending(f =>
            {
                Match m = Regex.Match(f, "version_manifest_v(\\d+).json");
                return m.Success ? int.Parse(m.Groups[1].Value) : 0;
            }).FirstOrDefault();

            Dictionary<string, string> latestVersions = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(latestVersionManifest))
            {
                JObject versionManifestJson = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(latestVersionManifest));

                string latestRelease = versionManifestJson["latest"]?["release"]?.ToString();
                string latestSnapshot = versionManifestJson["latest"]?["snapshot"]?.ToString();

                if (!string.IsNullOrEmpty(latestRelease))
                {
                    latestVersions["latest-release"] = latestRelease;
                }
                if (!string.IsNullOrEmpty(latestSnapshot))
                {
                    latestVersions["latest-snapshot"] = latestSnapshot;
                }
            }

            if (File.Exists(launcherProfilesPath))
            {
                JObject rootJson = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(launcherProfilesPath));
                var profiles = rootJson["profiles"] as JObject;

                foreach (var profile in profiles)
                {
                    string lastVersionId = profile.Value["lastVersionId"]?.ToString();

                    if (latestVersions.ContainsKey(lastVersionId))
                    {
                        lastVersionId = latestVersions[lastVersionId];
                    }

                    if (!string.IsNullOrEmpty(lastVersionId) && !comboBox1.Items.Contains(lastVersionId))
                    {
                        comboBox1.Items.Add(lastVersionId);
                    }
                }
            }
        }


        private void AdjustColumnWidthBasedOnListBoxContent(object sender, EventArgs e)
        {
            if (sender is ListBox listBox)
            {
                // 1. listBoxの名前から番号を取得
                var match = Regex.Match(listBox.Name, @"\d");
                if (!match.Success) return;

                int listBoxNumber;
                if (!int.TryParse(match.Value, out listBoxNumber))
                    return;

                if (listBoxNumber == 6) listBoxNumber = 7;

                // 非表示の場合は横幅を0に設定
                if (!listBox.Visible)
                {
                    pathPanel.ColumnStyles[listBoxNumber - 1].SizeType = SizeType.Absolute;
                    pathPanel.ColumnStyles[listBoxNumber - 1].Width = 0;
                    return;
                }

                // 2. listBox内の最も幅の広いテキストの幅を取得
                int maxTextWidth = listBox.Items
                    .Cast<string>()
                    .Max(item => TextRenderer.MeasureText(item, listBox.Font).Width);

                maxTextWidth += 25; // Margin or padding width

                // 3. 対応するColumnの幅を調整
                pathPanel.ColumnStyles[listBoxNumber - 1].SizeType = SizeType.Absolute;
                pathPanel.ColumnStyles[listBoxNumber - 1].Width = maxTextWidth;
            }

        }



        private JObject objects;
        void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // UIの初期化
            for (int r = 1; r <= 6; r++)
            {
                Label labelControl = this.pathPanel.Controls["label" + r] as Label;
                ListBox listBoxControl = this.pathPanel.Controls["listBox" + r] as ListBox;
                labelControl?.ResetText();
                listBoxControl?.Items.Clear();
                if (listBoxControl != null)
                {
                    listBoxControl.Visible = false;
                }

            }
            label1.Text = "Select Path";

            if (!(comboBox1.SelectedItem is string selectedVersion)) return;

            string versionJsonPath = RootPath + @"versions\" + selectedVersion + @"\" + selectedVersion + ".json";
            if (!File.Exists(versionJsonPath)) return;

            string versionJsonContent = File.ReadAllText(versionJsonPath);
            var versionJson = JObject.Parse(versionJsonContent);
            string assetId = versionJson["assetIndex"]?["id"]?.ToString();
            if (string.IsNullOrEmpty(assetId)) return;

            string assetIndexPath = RootPath + @"assets\indexes\" + assetId + ".json";
            if (!File.Exists(assetIndexPath)) return;

            JObject assetIndexJson = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(assetIndexPath));
            objects = assetIndexJson["objects"] as JObject;
            var soundsJsonData = objects?["minecraft/sounds.json"];
            string soundsJsonHash = soundsJsonData?["hash"]?.ToString();
            if (string.IsNullOrEmpty(soundsJsonHash)) return;

            string prefix = soundsJsonHash.Substring(0, 2); // hashの最初の2文字を取得
            string soundsJsonPath = RootPath + @"assets\objects\" + prefix + "\\" + soundsJsonHash;
            if (!File.Exists(soundsJsonPath)) return;

            string soundsJsonContent = File.ReadAllText(soundsJsonPath);
            soundsJson = JObject.Parse(soundsJsonContent); // soundsJsonに値をセット

            HashSet<string> soundPaths = new HashSet<string>();
            foreach (var key in soundsJson.Properties())
            {
                string[] parts = key.Name.Split('.');
                soundPaths.Add(parts[0]);
            }

            listBox1.Items.AddRange(soundPaths.ToArray());
            listBox1.Visible = true;
        }




        private string _selectedFullPath;
        private string _globalSoundPath;
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlaySpeed = BarSpeed;
            if (!(sender is ListBox currentListBox))
                return;

            string newPath = GetSelectedFullPath(currentListBox);

            // 直接listBox6でoggファイルが選択された場合の対応
            if (currentListBox.Name == "listBox6")
            {
                PlaySelectedSoundFromListBox6(_selectedFullPath);
                return; // 以降の処理は実行しない
            }
            else
            // 同じパスで、さらに音のパスである場合には、ランダムな音を再生する。
            if (_selectedFullPath == newPath && IsSoundPath(newPath))
            {
                DisposeSoundResources();
                PlayRandomSoundFromPath(newPath);
                return;
            }

            _selectedFullPath = newPath;

            int currentListBoxNumber = GetListBoxNumber(currentListBox);
            if (currentListBoxNumber == -1) return;

            int nextListBoxNumber = currentListBoxNumber + 1;

            // Clear and hide subsequent list boxes
            ClearAndHideSubsequentListBoxes(nextListBoxNumber);

            HashSet<string> nextCategories = GetNextCategories(_selectedFullPath, currentListBoxNumber);
            PopulateAndShowNextListBox(nextCategories, nextListBoxNumber);

            if (IsSoundPath(_selectedFullPath))
            {
                UpdateAndShowSoundList(_selectedFullPath);
                DisposeSoundResources();
                PlayRandomSoundFromPath(_selectedFullPath);
            }
        }

        private int GetListBoxNumber(ListBox listBox)
        {
            Match match = Regex.Match(listBox.Name, @"\d");
            return match.Success ? int.Parse(match.Value) : -1;
        }

        private void PopulateAndShowNextListBox(HashSet<string> nextCategories, int nextListBoxNumber)
        {
            if (nextCategories.Count == 0) return;

            Control targetControl = this.pathPanel.Controls["listBox" + nextListBoxNumber];
            if (targetControl is ListBox targetListBox)
            {
                targetListBox.Items.AddRange(nextCategories.ToArray());
                targetListBox.Visible = true;
            }
        }



        private bool IsSoundPath(string fullPath)
        {
            return soundsJson[fullPath] != null && soundsJson[fullPath]["sounds"] != null;
        }

        private void PlayRandomSoundFromPath(string soundPath)
        {
            // パスが存在しない場合はメソッドを終了
            if (soundsJson == null) return;
            var soundArray = soundsJson[soundPath]["sounds"].ToArray();
            if (soundArray.Length == 0) return;

            var randomIndex = new Random().Next(0, soundArray.Length);
            var randomOggData = soundArray[randomIndex];

            string randomOgg;
            if (randomOggData is JObject soundObject && soundObject["name"] != null)
            {
                randomOgg = soundObject["name"].ToString();
            }
            else
            {
                randomOgg = randomOggData.ToString();
            }

            // listBox6の選択を更新
            ListBox listBox6 = (ListBox)this.pathPanel.Controls["listBox6"];
            if (listBox6.Items.Count > randomIndex)
            {
                listBox6.SelectedIndex = randomIndex;
            }

            _globalSoundPath = "minecraft/sounds/" + randomOgg + ".ogg";
            PlaySound();
        }

        private void PlaySelectedSoundFromListBox6(string soundPath)
        {
            var soundsToken = soundsJson[soundPath]?["sounds"];
            if (soundsToken == null) return;

            string selectedOggName = listBox6.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedOggName)) return;

            var selectedOggData = soundsToken
                .OfType<JObject>()
                .FirstOrDefault(oggData => oggData["name"]?.ToString().EndsWith(selectedOggName) == true)
                ?? soundsToken.FirstOrDefault(oggData => oggData.ToString().EndsWith(selectedOggName));

            if (selectedOggData == null) return;

            string fullPath;
            if (selectedOggData is JObject oggObject)
            {
                fullPath = oggObject["name"]?.ToString();
            }
            else
            {
                fullPath = selectedOggData.ToString();
            }

            _globalSoundPath = "minecraft/sounds/" + fullPath + ".ogg";
            DisposeSoundResources();
            PlaySound();
        }



        private string GetNextCategory(string fullPath, string _selectedFullPath, int depth)
        {
            var paths = fullPath.Split('.');
            if (paths.Length <= depth) return null;
            if (string.Join(".", paths.Take(depth)) != _selectedFullPath) return null;
            return paths[depth];
        }

        private string GetSelectedFullPath(ListBox currentListBox)
        {
            StringBuilder fullPath = new StringBuilder();

            int listBoxIndex = int.Parse(Regex.Match(currentListBox.Name, @"\d").Value);
            for (int i = 1; i < listBoxIndex; i++)
            {
                Control previousList = this.pathPanel.Controls["listBox" + i];
                if (previousList is ListBox previousListBox && previousListBox.SelectedItem != null)
                {
                    fullPath.Append(previousListBox.SelectedItem.ToString()).Append(".");
                }
            }

            if (currentListBox.SelectedItem != null)
            {
                fullPath.Append(currentListBox.SelectedItem.ToString());
            }

            return fullPath.ToString();
        }

        private void ClearAndHideSubsequentListBoxes(int startingFrom)
        {
            for (int i = startingFrom; i <= 6; i++)
            {
                Control list = this.pathPanel.Controls["listBox" + i];
                if (list is ListBox listBoxToClear)
                {
                    listBoxToClear.Items.Clear();
                    listBoxToClear.Visible = false;

                    if (i == 6)
                    {
                        label6.Visible = false;
                    }
                }
            }
        }

        private HashSet<string> GetNextCategories(string _selectedFullPath, int depth)
        {
            HashSet<string> nextCategories = new HashSet<string>();
            foreach (var key in soundsJson.Properties())
            {
                string nextCategory = GetNextCategory(key.Name, _selectedFullPath, depth);
                if (nextCategory != null)
                {
                    nextCategories.Add(nextCategory);
                }
            }
            return nextCategories;
        }

        private void UpdateAndShowSoundList(string _selectedFullPath)
        {
            // If it's the last category and there's a sound to display
            var soundData = soundsJson[_selectedFullPath]["sounds"];
            Dictionary<string, string> soundPathMapping = new Dictionary<string, string>();

            foreach (var sound in soundData)
            {
                string soundName = sound is JObject soundObject && soundObject["name"] != null
                    ? soundObject["name"].ToString()
                    : sound.ToString();

                string displayedSoundName = soundName.Split('/').Last();

                if (!soundPathMapping.ContainsKey(displayedSoundName))
                {
                    soundPathMapping.Add(displayedSoundName, soundName);
                }
            }

            ListBox listBox6 = (ListBox)this.pathPanel.Controls["listBox6"];

            listBox6.Items.AddRange(soundPathMapping.Keys.ToArray());
            listBox6.Visible = true;

            // Select a random item in listBox6
            listBox6.SelectedIndex = new Random().Next(0, listBox6.Items.Count);

            // Handle the visibility of label6 when listBox6 becomes visible
            label6.Visible = true;
            label6.Text = ".ogg";
        }



        private ISoundOut _soundOut;
        private IWaveSource _waveSource;
        private string _generatedCommand;

        private void DisposeSoundResources()
        {
            _soundOut?.Stop();
            _soundOut?.Dispose();
            _soundOut = null;

            _waveSource?.Dispose();
            _waveSource = null;
        }


        private class PlaybackSpeedAdjuster : SampleAggregatorBase
        {
            private readonly ISampleSource _source;

            public PlaybackSpeedAdjuster(ISampleSource source, float playSpeed)
                : base(source.ChangeSampleRate((int)(source.WaveFormat.SampleRate * playSpeed)))
            {
                _source = source;
            }

            public override int Read(float[] buffer, int offset, int count)
            {
                return _source.Read(buffer, offset, count);
            }
        }

        private void PlaySound()
        {
            if (!float.TryParse(PitchText.Text, out var n)) return;
            // PlaySpeedの値を0.5と2.0の間にクリップ
            PlaySpeed = Math.Max(0.5f, Math.Min(2.0f, PlaySpeed));
            string soundPath = _globalSoundPath;
            if (soundPath == null) return;

            var soundData = objects?[soundPath];
            string PlayHash = soundData?["hash"]?.ToString();

            // ハッシュが見つからなかった場合はメソッドを終了
            if (string.IsNullOrEmpty(PlayHash)) return;

            if (comboBox2.SelectedIndex == 0)
            {
                UpdateCommand();
            }
            else
            {
                CommandText.Text = _globalSoundPath;
            }

            float volume = MuteButton.Checked ? 0f : PlayVolume;

            var _waveSource = new NvorbisToCSCore(RootPath + @"assets\objects\" + PlayHash.Substring(0, 2) + @"\" + PlayHash);
            var playbackSpeedAdjuster = new PlaybackSpeedAdjuster(_waveSource.ToSampleSource(), PlaySpeed);

            _soundOut = new WasapiOut();
            _soundOut.Initialize(playbackSpeedAdjuster.ToWaveSource());
            _soundOut.Volume = volume;
            _soundOut.Play();
        }
        private void UpdateCommand()
        {
            List<string> commandParts = new List<string>
                {
                    "playsound minecraft:" + _selectedFullPath,
                    comPara_source.Text,
                    comPara_selector.Text,
                    comPara_posx.Text,
                    comPara_posy.Text,
                    comPara_posz.Text,
                    comPara_vol.Text,
                    PlaySpeed.ToString(CultureInfo.InvariantCulture),
                    comPara_volmin.Text
                };
            CommandText.Text = string.Join(" ", commandParts);
        }



        private void PlayButton_Click(object sender, EventArgs e)
        {
            DisposeSoundResources();
            //playCheckboxSelectedがチェックされている場合
            if (playCheckboxSelected.Checked || playCheckboxNotSelected.Checked)
            {
                //itemsのリスト作成
                List<string> items = new List<string>();
                //playCheckboxSelectedをチェック時にitemsをlistBox_coms.SelectedItemsへ追加
                if (playCheckboxSelected.Checked) items.AddRange(listBox_coms.SelectedItems.Cast<string>());
                //playCheckboxNotSelectedをチェック時にitemsへlistBox_comsでSelectedしていない項目を追加(重複なども考慮してindexで指定、無選択時にはnull回避)
                if (playCheckboxNotSelected.Checked) items.AddRange(listBox_coms.Items.Cast<string>().ToList().Where((item, index) => !listBox_coms.SelectedIndices.Contains(index)));
                //リストの要素数分、パスやピッチ、をリストとして取得
                List<string> paths = new List<string>();
                List<string> pitches = new List<string>();
                List<string> volumes = new List<string>();
                foreach (var item in items)
                {
                    if (item.Contains("playsound"))
                    {
                        int index = item.IndexOf("playsound") + "playsound".Length;
                        string[] words = item.Substring(index).Trim().Split(' ');

                        if (words.Length == 9) // "playsound"の後に半角スペース区切りで9つの単語が存在する場合
                        {
                            paths.Add(words[0].StartsWith("minecraft:") ? words[0].Substring("minecraft:".Length) : words[0]);
                            pitches.Add(words[7]);
                            volumes.Add(words[6]);
                        }
                    }
                }
                //リストの要素数分、サウンドを同時再生
                for (int i = 0; i < paths.Count; i++)
                {
                    PlaySpeed = float.Parse(pitches[i], CultureInfo.InvariantCulture);
                    PlayVolume = float.Parse(volumes[i], CultureInfo.InvariantCulture);
                    PlayRandomSoundFromPath(paths[i]);
                }
            }
            //playCheckboxParameterがチェックされている場合
            if (playCheckboxParameter.Checked)
            {
                PlaySpeed = BarSpeed;
                if (_selectedFullPath != null) PlayRandomSoundFromPath(_selectedFullPath);
            }
            PlaySpeed = float.Parse(PitchText.Text, CultureInfo.InvariantCulture);
            PlayVolume = 1 + VolumeBar.Value * 0.01f;
            UpdateCommand();
        }

        private void PitchButton_Click(object sender, EventArgs e)
        {
            Button NowPitch = (Button)sender;
            PlaySpeed = float.Parse(NowPitch.Text, CultureInfo.InvariantCulture);
            DisposeSoundResources();
            if (_selectedFullPath != null) PlayRandomSoundFromPath(_selectedFullPath);
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (_soundOut != null)
            {
                _soundOut.Stop();
            }
        }
        private bool ignoreEvents = false; // イベントを無視するかどうかを制御するフラグ

        private void PitchText_TextChanged(object sender, EventArgs e)
        {
            if (ignoreEvents) return; // イベントを無視する場合、ここで処理を中断

            if (float.TryParse(PitchText.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out float enteredSpeed))
            {
                enteredSpeed = Math.Max(0.5f, Math.Min(2.0f, enteredSpeed));

                int newValue;
                if (enteredSpeed >= 1.0f)
                {
                    newValue = (int)((enteredSpeed - 1) * 100);
                }
                else
                {
                    newValue = (int)((enteredSpeed - 1) * 200);
                }

                ignoreEvents = true; // PitchBarのValueを設定する前に、イベントを一時的に無効にする
                PitchBar.Value = newValue;
                BarSpeed = enteredSpeed;
                ignoreEvents = false; // 更新が終わったら、イベントを再び有効にする
            }

            PlayButton_Click(null, EventArgs.Empty);
        }

        private void PitchBar_Scroll(object sender, EventArgs e)
        {
            if (ignoreEvents) return; // イベントを無視する場合、ここで処理を中断

            int i = PitchBar.Value;
            if (i < 0)
            {
                BarSpeed = 1 - i * 0.5f / PitchBar.Minimum;
            }
            else
            {
                BarSpeed = 1 + i * 1.0f / PitchBar.Maximum;
            }

            ignoreEvents = true; // PitchTextのテキストを更新する前に、イベントを一時的に無効にする
            // InvariantCultureを使用して、小数点が常にピリオドであることを確認します。
            PitchText.Text = BarSpeed.ToString("F3", CultureInfo.InvariantCulture).TrimEnd('0').TrimEnd('.');
            ignoreEvents = false; // 更新が終わったら、イベントを再び有効にする
        }


        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            PlayVolume = 1 + VolumeBar.Value * 0.01f;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            //言語圏デバッグ
            //var culture = new CultureInfo("ja-JP");
            //var culture = new CultureInfo("de-DE");
            //CultureInfo.DefaultThreadCurrentCulture = culture;
            //CultureInfo.DefaultThreadCurrentUICulture = culture;

            CommandText.Focus();
            CommandText.SelectAll();
            Clipboard.SetText(CommandText.Text);
        }
        private void ListBox_Click(object sender, EventArgs e)
        {
            ListBox NowList = (ListBox)sender;
            NowList.SelectedIndex = -1;
            NowList.Focus();
        }
        private void CheckStateChanged(object sender, EventArgs e)
        {
            if (MuteButton.Checked)
            {
                if (_soundOut != null) _soundOut.Stop();
                MuteButton.Text = "🔈";
            }
            else
            {
                MuteButton.Text = "🔊";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;  // 最初のアイテムをデフォルトで選択
            Toggle_CommandPanel();
            Initialization_CommandPanel(); // commandタブに初期値反映
            CommandText.Text = " ";
            checkBoxPanel.Visible = false;  //最初は全再生ボタン非表示
            playCheckboxParameter.Checked = true; //最初はParameterチェック

        }
        bool openedUI = false;
        private void Toggle_CommandPanel()
        {
            pathPanel.Height = this.ClientSize.Height - comBottomPanel.Height - 6;
            if (openedUI)
            {
                pathPanel.Height -= comUpPanel.Height + 8;
            }
            else
            {
            }
            openedUI = !openedUI;
        }
        private void Initialization_CommandPanel()
        {
            comPara_selectedFile.Text = " ";
            List<string> items = new List<string> { "master", "music", "record", "weather", "block", "hostile", "neutral", "player", "ambient", "voice" };
            comPara_source.Items.AddRange(items.ToArray());
            comPara_source.SelectedIndex = 0;
            comPara_selector.Text = "@a";
            comPara_posx.Text = "~";
            comPara_posy.Text = "~";
            comPara_posz.Text = "~";
            comPara_vol.Text = "1.0";
            comPara_volmin.Text = "0.0";
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soundsJson != null && IsSoundPath(_selectedFullPath))
            {
                PlaySound();
            }
            else
            {
                CommandText.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toggle_CommandPanel();
        }
        private void button1_Paint(object sender, PaintEventArgs e)
        {
            string symbol;
            if (openedUI)
            {
                symbol = "▲";
            }
            else
            {
                symbol = "▼";
            }

            // ボタンの中心を計算
            int centerX = 8;
            int centerY = 8;

            // FontとBrushを設定
            Font font = new Font("Arial", 16, FontStyle.Bold); // フォントの種類とサイズを設定
            Brush brush = Brushes.Black; // 描画色を設定

            // スケール変換の値
            float scaleX = 2.0f; // 横方向のスケール値
            float scaleY = 1.0f; // 縦方向のスケール値

            using (GraphicsPath path = new GraphicsPath())
            {
                // 文字をGraphicsPathに追加
                path.AddString(symbol, font.FontFamily, (int)font.Style, font.Size, new Point(centerX, centerY), new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });

                // 変換マトリクスを作成してスケール変換を適用
                Matrix transformMatrix = new Matrix();
                transformMatrix.Scale(scaleX, scaleY);

                // 変換を適用
                path.Transform(transformMatrix);

                // 描画
                e.Graphics.FillPath(brush, path);
            }
        }

        private void comPara_TextUpdate(object sender, EventArgs e)
        {
            UpdateCommand();
        }

        private string fileName;
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            listBox_coms.SelectionMode = SelectionMode.None;

            var dialog = sender as OpenFileDialog;
            if (dialog == null) return;

            try
            {
                fileName = dialog.FileName;
                comPara_selectedFile.Text = Path.GetFileName(fileName);

                // 同期的に全行読み込み
                var lines = File.ReadAllLines(fileName);

                // バインディングリストを作成し、これをデータソースに設定
                listBox_coms.DataSource = new BindingList<string>(lines);
                listBox_coms.SelectionMode = SelectionMode.MultiExtended;

                comsList_save.Font = new Font(comsList_save.Font, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the file: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_selectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }


        private void MoveSelectedItems(int direction)
        {
            // リストボックスの項目を保持
            var items = listBox_coms.Items.Cast<string>().ToList();
            //var selectedItems = new List<string>();
            var selectedIndices = new List<int>();
            // 移動の方向に応じて、選択項目のインデックスを適切に処理
            IEnumerable<int> orderedIndices = direction < 0 ?
                listBox_coms.SelectedIndices.Cast<int>().OrderBy(i => i) :
                listBox_coms.SelectedIndices.Cast<int>().OrderByDescending(i => i);

            // 選択されている各項目について処理
            foreach (int index in orderedIndices)
            {
                // 移動先のインデックスを計算
                int newIndex = index + direction;

                // 移動先がリストの範囲外の場合は処理を終了
                if (newIndex < 0 || newIndex >= items.Count) return;

                // 項目を移動
                string item = items[index];
                items.RemoveAt(index);
                items.Insert(newIndex, item);

                // 移動した項目とインデックスを保存
                //selectedItems.Add(item);
                selectedIndices.Add(newIndex);
            }

            // リストボックスの更新
            listBox_coms.BeginUpdate();
            listBox_coms.DataSource = null;
            listBox_coms.DataSource = items;
            listBox_coms.ClearSelected();

            // 移動した項目を選択状態にする
            foreach (var newIndex in selectedIndices)
            {
                listBox_coms.SetSelected(newIndex, true);
            }
            listBox_coms.EndUpdate();
        }

        private void comsList_moveUp_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(-1);
        }

        private void comsList_moveDown_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(1);
        }


        private void listBox_coms_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var listBox = sender as ListBox;
            if (listBox == null) return;

            var item = listBox.Items[e.Index].ToString();

            bool shouldDrawDefaultBackground = false;
            if (item.Contains("playsound"))
            {
                int index = item.IndexOf("playsound") + "playsound".Length;
                string[] words = item.Substring(index).Trim().Split(' ');

                if (words.Length == 9) // "playsound"の後に半角スペース区切りで9つの単語が存在する場合
                {
                    shouldDrawDefaultBackground = true;
                }
            }

            if (shouldDrawDefaultBackground)
            {
                e.DrawBackground(); // デフォルトの背景色
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds); // 背景を薄灰色に描画
            }
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            // 項目が選択されている場合は、背景をデフォルトの色(通常の青)にする
            if (isSelected)
            {
                e.Graphics.FillRectangle(SystemBrushes.Highlight, e.Bounds);
            }

            e.Graphics.DrawString(item, e.Font, Brushes.Black, e.Bounds); // デフォルトの文字色
            e.DrawFocusRectangle(); // フォーカス矩形
        }

        private void comsList_add_Click(object sender, EventArgs e)
        {
            string newItem = CommandText.Text.Trim();
            if (!string.IsNullOrEmpty(newItem))
            {
                var items = listBox_coms.Items.Cast<string>().ToList();

                // 選択されているアイテムのインデックスの最大値を取得
                var selectedIndices = listBox_coms.SelectedIndices;
                int lastSelectedIndex = selectedIndices.Count > 0 ? selectedIndices[selectedIndices.Count - 1] : -1;

                // もし何も選択されていない、または最後のアイテムが選択されている場合は、リストの最後に追加
                int insertIndex = (lastSelectedIndex >= 0 && lastSelectedIndex < items.Count - 1) ? lastSelectedIndex + 1 : items.Count;

                // 新しいアイテムを挿入
                items.Insert(insertIndex, newItem);

                listBox_coms.DataSource = null; // リストボックスのデータソースを一時的にnullにする
                listBox_coms.DataSource = items; // 更新したitemsリストをデータソースに設定
                listBox_coms.ClearSelected(); // 既に選択されている項目の選択を解除
                listBox_coms.SelectedIndex = insertIndex; // 追加した項目を選択状態にする

                listBox_coms_DoubleClick(null, EventArgs.Empty);
            }
        }


        private bool isRemoveConfirmedOnce = false;
        private void comsList_remove_Click(object sender, EventArgs e)
        {
            if (listBox_coms.SelectedItem == null) return;

            if (!isRemoveConfirmedOnce)
            {
                DialogResult result = MessageBox.Show("Do you want to remove the selected items?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;
                isRemoveConfirmedOnce = true;
            }

            var selectedIndices = listBox_coms.SelectedIndices.Cast<int>().OrderBy(i => i).ToList(); // 選択されているインデックスを昇順で取得
            var items = listBox_coms.Items.Cast<string>().ToList(); // 現在の全アイテムのリスト

            // 最初に削除される要素のインデックスを記録します。
            int firstIndexRemoved = selectedIndices.First(); // 最初に削除される要素（最もインデックス番号が小さい）

            // 選択されたアイテムを削除します。
            foreach (var index in selectedIndices.OrderByDescending(i => i)) // 削除はインデックスの大きい順に行う
            {
                if (index < items.Count)
                {
                    items.RemoveAt(index); // アイテムを削除
                }
            }
            // 選択インデックス更新
            int newIndex = (items.Any() && firstIndexRemoved > 0) ? firstIndexRemoved - 1 : -1;

            listBox_coms.DataSource = null; // リストボックスのデータソースを一時的にnullにする
            listBox_coms.DataSource = items; // 更新したitemsリストをデータソースに設定
            listBox_coms.ClearSelected(); // 既に選択されている項目の選択を解除
            listBox_coms.SelectedIndex = newIndex;
        }







        private void comsList_save_Click(object sender, EventArgs e)
        {
            if (listBox_coms.Items.Count == 0) return;

            string selectedFile = string.IsNullOrWhiteSpace(comPara_selectedFile.Text) ? "favorites.mcfunction" : comPara_selectedFile.Text;

            // fileNameが空、またはcomPara_selectedFileがfileNameのファイル名と異なる場合は、SaveFileDialogを表示
            if (string.IsNullOrEmpty(fileName) || string.IsNullOrWhiteSpace(comPara_selectedFile.Text) || Path.GetFileName(fileName) != selectedFile)
            {
                saveFileDialog1.FileName = selectedFile;
                if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                {
                    // ユーザーが「キャンセル」をクリックした場合は、処理を中断
                    return;
                }

                // ユーザーが選択したファイルのパスを取得
                fileName = saveFileDialog1.FileName;
            }

            try
            {
                // ファイルを保存
                File.WriteAllLines(fileName, listBox_coms.Items.Cast<string>().ToArray());
                comsList_save.Font = new Font(comsList_save.Font, FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the file: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listBox_coms_DataSourceChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox == null) return;

            var currentDataSource = listBox.DataSource as List<string> ?? new List<string>();

            if (currentDataSource.Any())
            {
                comsList_save.Font = new Font(comsList_save.Font, FontStyle.Bold); // フォントを太字に変更
            }
            else
            {
                comsList_save.Font = new Font(comsList_save.Font, FontStyle.Regular); // フォントを通常に戻す
            }
        }

        private void comPara_vol_bar_Scroll(object sender, EventArgs e)
        {
            comPara_vol.Text = (comPara_vol_bar.Value * 0.1).ToString("F1", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void comPara_vol_TextChanged(object sender, EventArgs e)
        {
            // TryParseにInvariantCultureを適用
            if (float.TryParse(comPara_vol.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float enteredVolume))
            {
                // enteredVolumeの値を0.0と1.0の間にクリップ
                enteredVolume = Math.Max(0.0f, Math.Min(1.0f, enteredVolume));

                // 0.0～1.0の範囲を0～10の範囲にマッピング
                int newValue = (int)(enteredVolume * 10);

                // comPara_vol_barのValueを更新
                comPara_vol_bar.Value = newValue;
            }
            PlayButton_Click(null, EventArgs.Empty);
        }

        // comPara_volminに対しても同様の処理
        private void comPara_volmin_bar_Scroll(object sender, EventArgs e)
        {
            comPara_volmin.Text = (comPara_volmin_bar.Value * 0.1).ToString("F1", System.Globalization.CultureInfo.InvariantCulture);
        }

        private void comPara_volmin_TextChanged(object sender, EventArgs e)
        {
            // TryParseにInvariantCultureを適用
            if (float.TryParse(comPara_volmin.Text, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out float enteredVolume))
            {
                // enteredVolumeの値を0.0と1.0の間にクリップ
                enteredVolume = Math.Max(0.0f, Math.Min(1.0f, enteredVolume));

                // 0.0～1.0の範囲を0～10の範囲にマッピング
                int newValue = (int)(enteredVolume * 10);

                // comPara_volmin_barのValueを更新
                comPara_volmin_bar.Value = newValue;
            }
            PlayButton_Click(null, EventArgs.Empty);
        }


        //プログラム終了時にサウンドを停止
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeSoundResources();
        }

        private void listBox_coms_MouseUp(object sender, MouseEventArgs e)
        {
            listBox_coms.SelectionMode = SelectionMode.MultiExtended;
            //同時再生ボタンが非表示で、listBox_comsを複数選択時
            if (!checkBoxPanel.Visible && 1 < listBox_coms.SelectedItems.Count)
            {
                //同時再生ボタンを表示
                checkBoxPanel.Visible = true;
                //playCheckboxParameterのチェックを外し、playCheckboxSelectedのチェックを入れる
                playCheckboxParameter.Checked = false;
                playCheckboxSelected.Checked = true;
            }
        }

        private void comsList_rewrite_Click(object sender, EventArgs e)
        {
            //選択中の項目を、現在のコマンドに置き換える
            if (listBox_coms.SelectedItem != null)
            {
                string newItem = CommandText.Text.Trim();
                if (!string.IsNullOrEmpty(newItem))
                {
                    var items = listBox_coms.Items.Cast<string>().ToList();
                    int selectedIndex = listBox_coms.SelectedIndex;
                    //listBox_coms.SelectedIndicesを一時的に保存
                    var selectedIndices = listBox_coms.SelectedIndices.Cast<int>().ToList();
                    //複数選択時、選択中の項目を、現在のコマンドに置き換える
                    foreach (int index in selectedIndices)
                    {
                        items[index] = newItem;
                    }
                    listBox_coms.DataSource = items; // 更新したitemsリストをデータソースに設定
                    //一時的にセレクトを解除
                    listBox_coms.SelectedIndex = -1;
                    //selectedIndicesを復元
                    foreach (int index in selectedIndices)
                    {
                        listBox_coms.SetSelected(index, true);
                    }

                }
                listBox_coms_DoubleClick(null, EventArgs.Empty);
            }
        }

        private void listBox_coms_DoubleClick(object sender, EventArgs e)
        {
            if (listBox_coms.SelectedItem != null)
            {
                string selectedText = listBox_coms.SelectedItem.ToString();

                if (selectedText.Contains("playsound"))
                {
                    int index = selectedText.IndexOf("playsound") + "playsound".Length;
                    string playsoundFollowing = selectedText.Substring(index).Trim();

                    List<string> words = playsoundFollowing.Split(' ').ToList();

                    // 9つの単語がある場合のみ処理を進める
                    if (words.Count == 9)
                    {
                        _selectedFullPath = words[0].StartsWith("minecraft:") ? words[0].Substring("minecraft:".Length) : words[0];
                        List<string> fullPathList = _selectedFullPath.Split('.').ToList();
                        if (fullPathList == null || !fullPathList.Any()) return;

                        for (int i = 0; i < fullPathList.Count; i++)
                        {
                            Control control = this.Controls.Find("listBox" + (i + 1), true).FirstOrDefault();
                            if (control is ListBox listBox)
                            {
                                int selectedIndex = listBox.FindString(fullPathList[i]);
                                if (selectedIndex != -1)
                                {
                                    listBox.SelectedIndex = selectedIndex;
                                    listBox_SelectedIndexChanged(listBox, EventArgs.Empty);
                                }
                            }
                        }

                        comPara_source.Text = words[1];
                        comPara_selector.Text = words[2];
                        comPara_posx.Text = words[3];
                        comPara_posy.Text = words[4];
                        comPara_posz.Text = words[5];
                        comPara_vol.Text = words[6];
                        PitchText.Text = words[7];
                        comPara_volmin.Text = words[8];
                    }
                }
            }
        }
    }
}