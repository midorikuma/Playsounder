using CSCore;
using CSCore.SoundOut;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NVorbis;
using System;
using System.Collections.Generic;
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
                    tableLayoutPanel1.ColumnStyles[listBoxNumber - 1].SizeType = SizeType.Absolute;
                    tableLayoutPanel1.ColumnStyles[listBoxNumber - 1].Width = 0;
                    return;
                }

                // 2. listBox内の最も幅の広いテキストの幅を取得
                int maxTextWidth = listBox.Items
                    .Cast<string>()
                    .Max(item => TextRenderer.MeasureText(item, listBox.Font).Width);

                maxTextWidth += 25; // Margin or padding width

                // 3. 対応するColumnの幅を調整
                tableLayoutPanel1.ColumnStyles[listBoxNumber - 1].SizeType = SizeType.Absolute;
                tableLayoutPanel1.ColumnStyles[listBoxNumber - 1].Width = maxTextWidth;
            }
        }



        private JObject objects;
        void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // UIの初期化
            for (int r = 1; r <= 6; r++)
            {
                Label labelControl = this.tableLayoutPanel1.Controls["label" + r] as Label;
                ListBox listBoxControl = this.tableLayoutPanel1.Controls["listBox" + r] as ListBox;
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

            Control targetControl = this.tableLayoutPanel1.Controls["listBox" + nextListBoxNumber];
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
            ListBox listBox6 = (ListBox)this.tableLayoutPanel1.Controls["listBox6"];
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
                Control previousList = this.tableLayoutPanel1.Controls["listBox" + i];
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
                Control list = this.tableLayoutPanel1.Controls["listBox" + i];
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

            ListBox listBox6 = (ListBox)this.tableLayoutPanel1.Controls["listBox6"];

            listBox6.Items.AddRange(soundPathMapping.Keys.ToArray());
            listBox6.Visible = true;

            // Select a random item in listBox6
            listBox6.SelectedIndex = new Random().Next(0, listBox6.Items.Count);

            // Handle the visibility of label6 when listBox6 becomes visible
            label6.Visible = true;
            label6.Text = "ogg files";
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
            PlaySpeed = float.Parse(PitchText.Text);
            // PlaySpeedの値を0.5と2.0の間にクリップ
            PlaySpeed = Math.Max(0.5f, Math.Min(2.0f, PlaySpeed));
            Plays();
        }
        private void Plays()
        {
            DisposeSoundResources();
            if (_globalSoundPath == null) return;

            var soundData = objects?[_globalSoundPath];
            string PlayHash = soundData?["hash"]?.ToString();

            // ハッシュが見つからなかった場合はメソッドを終了
            if (string.IsNullOrEmpty(PlayHash)) return;

            if (comboBox2.SelectedIndex == 0)
            {
                _generatedCommand = "/playsound minecraft:" + _selectedFullPath
                    + " master @a ~ ~ ~ 1 " + PlaySpeed + " 0";
                CommandText.Text = _generatedCommand;
            }
            else
            {
                CommandText.Text = _globalSoundPath;
            }

            float volume = MuteButton.Checked ? 0f : PlayVolume;

            _waveSource = new NvorbisToCSCore(RootPath + @"assets\objects\" + PlayHash.Substring(0, 2) + @"\" + PlayHash);

            // Adjust the playback speed using our custom PlaybackSpeedAdjuster
            var playbackSpeedAdjuster = new PlaybackSpeedAdjuster(_waveSource.ToSampleSource(), PlaySpeed);

            _soundOut = new WasapiOut();
            _soundOut.Initialize(playbackSpeedAdjuster.ToWaveSource());
            _soundOut.Volume = volume;
            _soundOut.Play();
        }







        private void PlayButton_Click(object sender, EventArgs e)
        {
            PlaySpeed = BarSpeed;
            PlaySound();
        }

        private void PitchButton_Click(object sender, EventArgs e)
        {
            Button NowPitch = (Button)sender;
            PlaySpeed = float.Parse(NowPitch.Text);
            Plays();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (_soundOut != null)
            {
                _soundOut.Stop();
            }
        }
        private void PitchText_TextChanged(object sender, EventArgs e)
        {
            // PitchTextの値をfloatとして取得
            if (float.TryParse(PitchText.Text, out float enteredSpeed))
            {
                // enteredSpeedの値を0.5と2.0の間にクリップ
                enteredSpeed = Math.Max(0.5f, Math.Min(2.0f, enteredSpeed));

                // 0.5～2.0の範囲を-100～100の範囲にマッピング
                int newValue;
                if (enteredSpeed >= 1.0f)
                {
                    newValue = (int)((enteredSpeed - 1) * 100);
                }
                else
                {
                    newValue = (int)((enteredSpeed - 1) * 200);
                }

                // PitchBarのValueを更新
                PitchBar.Value = newValue;
                BarSpeed = enteredSpeed;
            }
            PlayButton_Click(sender, e);
        }
        private void PitchBar_Scroll(object sender, EventArgs e)
        {
            int i = PitchBar.Value;
            if (i < 0)
            {
                BarSpeed = 1 - i * 0.5f / PitchBar.Minimum;
            }
            else
            {
                BarSpeed = 1 + i * 1.0f / PitchBar.Maximum;
            }
            PitchText.Text = BarSpeed.ToString();
        }

        private void VolumeBar_Scroll(object sender, EventArgs e)
        {
            PlayVolume = 1 + VolumeBar.Value * 0.01f;
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
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
                if (_soundOut!=null) _soundOut.Stop();
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
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (soundsJson != null && IsSoundPath(_selectedFullPath))
            {
                PlaySound();
            }
            else
            {
                CommandText.Text = "";
            }
        }
    }
}