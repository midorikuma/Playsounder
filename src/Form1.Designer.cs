namespace Playsounder
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            listBox2 = new System.Windows.Forms.ListBox();
            label2 = new System.Windows.Forms.Label();
            listBox3 = new System.Windows.Forms.ListBox();
            listBox4 = new System.Windows.Forms.ListBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            listBox5 = new System.Windows.Forms.ListBox();
            label5 = new System.Windows.Forms.Label();
            Pitch0Button = new System.Windows.Forms.Button();
            PitchBar = new System.Windows.Forms.TrackBar();
            Pitch1Button = new System.Windows.Forms.Button();
            Pitch2Button = new System.Windows.Forms.Button();
            PitchText = new System.Windows.Forms.TextBox();
            StopButton = new System.Windows.Forms.Button();
            VolumeBar = new System.Windows.Forms.TrackBar();
            CommandText = new System.Windows.Forms.TextBox();
            CopyButton = new System.Windows.Forms.Button();
            MuteButton = new System.Windows.Forms.CheckBox();
            pathPanel = new System.Windows.Forms.TableLayoutPanel();
            listBox1 = new System.Windows.Forms.ListBox();
            label6 = new System.Windows.Forms.Label();
            listBox6 = new System.Windows.Forms.ListBox();
            button1 = new System.Windows.Forms.Button();
            comBottomPanel1 = new System.Windows.Forms.TableLayoutPanel();
            comboBox2 = new System.Windows.Forms.ComboBox();
            PlayButton = new System.Windows.Forms.Button();
            comBottomPanel2 = new System.Windows.Forms.TableLayoutPanel();
            checkBoxPanel = new System.Windows.Forms.TableLayoutPanel();
            playCheckboxParameter = new System.Windows.Forms.CheckBox();
            playCheckboxNotSelected = new System.Windows.Forms.CheckBox();
            playCheckboxSelected = new System.Windows.Forms.CheckBox();
            comPanel = new System.Windows.Forms.TableLayoutPanel();
            comUpPanel = new System.Windows.Forms.TableLayoutPanel();
            comParasPanel = new System.Windows.Forms.TableLayoutPanel();
            comVolminPanel = new System.Windows.Forms.TableLayoutPanel();
            comPara_volmin = new System.Windows.Forms.TextBox();
            comPara_volmin_bar = new System.Windows.Forms.TrackBar();
            comFilePanel = new System.Windows.Forms.TableLayoutPanel();
            comsList_save = new System.Windows.Forms.Button();
            comPara_selectedFile = new System.Windows.Forms.TextBox();
            button_selectFile = new System.Windows.Forms.Button();
            comPara_source = new System.Windows.Forms.ComboBox();
            comPara_selector = new System.Windows.Forms.TextBox();
            comPosPanel = new System.Windows.Forms.TableLayoutPanel();
            comPara_posx = new System.Windows.Forms.TextBox();
            comPara_posy = new System.Windows.Forms.TextBox();
            comPara_posz = new System.Windows.Forms.TextBox();
            comVolPanel = new System.Windows.Forms.TableLayoutPanel();
            comPara_vol = new System.Windows.Forms.TextBox();
            comPara_vol_bar = new System.Windows.Forms.TrackBar();
            comSavePanel = new System.Windows.Forms.TableLayoutPanel();
            comsList_moveUp = new System.Windows.Forms.Button();
            comsList_moveDown = new System.Windows.Forms.Button();
            comsList_remove = new System.Windows.Forms.Button();
            comsList_add = new System.Windows.Forms.Button();
            comsList_rewrite = new System.Windows.Forms.Button();
            listBox_coms = new System.Windows.Forms.ListBox();
            comBottomPanel = new System.Windows.Forms.TableLayoutPanel();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)PitchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).BeginInit();
            pathPanel.SuspendLayout();
            comBottomPanel1.SuspendLayout();
            comBottomPanel2.SuspendLayout();
            checkBoxPanel.SuspendLayout();
            comPanel.SuspendLayout();
            comUpPanel.SuspendLayout();
            comParasPanel.SuspendLayout();
            comVolminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comPara_volmin_bar).BeginInit();
            comFilePanel.SuspendLayout();
            comPosPanel.SuspendLayout();
            comVolPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comPara_vol_bar).BeginInit();
            comSavePanel.SuspendLayout();
            comBottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.DefaultExt = "mcfunction";
            openFileDialog1.Filter = "mcfunction Files (*.mcfunction)|*.mcfunction|All Files (*.*)|*.*";
            openFileDialog1.ReadOnlyChecked = true;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.SupportMultiDottedExtensions = true;
            openFileDialog1.Title = "Please select a .mcfunction file";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Location = new System.Drawing.Point(4, 4);
            comboBox1.Margin = new System.Windows.Forms.Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(81, 23);
            comboBox1.TabIndex = 0;
            comboBox1.DropDown += comboBox1_OnDropDownOpened;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.Location = new System.Drawing.Point(4, 29);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Select Ver.";
            // 
            // listBox2
            // 
            listBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new System.Drawing.Point(121, 48);
            listBox2.Margin = new System.Windows.Forms.Padding(4);
            listBox2.Name = "listBox2";
            listBox2.Size = new System.Drawing.Size(109, 169);
            listBox2.TabIndex = 3;
            listBox2.Visible = false;
            listBox2.VisibleChanged += AdjustColumnWidthBasedOnListBoxContent;
            listBox2.MouseUp += listBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.Location = new System.Drawing.Point(121, 29);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(109, 15);
            label2.TabIndex = 4;
            // 
            // listBox3
            // 
            listBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new System.Drawing.Point(238, 48);
            listBox3.Margin = new System.Windows.Forms.Padding(4);
            listBox3.Name = "listBox3";
            listBox3.Size = new System.Drawing.Size(109, 169);
            listBox3.TabIndex = 5;
            listBox3.Visible = false;
            listBox3.VisibleChanged += AdjustColumnWidthBasedOnListBoxContent;
            listBox3.MouseUp += listBox_SelectedIndexChanged;
            // 
            // listBox4
            // 
            listBox4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new System.Drawing.Point(355, 48);
            listBox4.Margin = new System.Windows.Forms.Padding(4);
            listBox4.Name = "listBox4";
            listBox4.Size = new System.Drawing.Size(109, 169);
            listBox4.TabIndex = 6;
            listBox4.Visible = false;
            listBox4.VisibleChanged += AdjustColumnWidthBasedOnListBoxContent;
            listBox4.MouseUp += listBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.Location = new System.Drawing.Point(238, 29);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(109, 15);
            label3.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label4.Location = new System.Drawing.Point(355, 29);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(109, 15);
            label4.TabIndex = 8;
            // 
            // listBox5
            // 
            listBox5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox5.FormattingEnabled = true;
            listBox5.ItemHeight = 15;
            listBox5.Location = new System.Drawing.Point(472, 48);
            listBox5.Margin = new System.Windows.Forms.Padding(4);
            listBox5.Name = "listBox5";
            listBox5.Size = new System.Drawing.Size(109, 169);
            listBox5.TabIndex = 9;
            listBox5.Visible = false;
            listBox5.VisibleChanged += AdjustColumnWidthBasedOnListBoxContent;
            listBox5.MouseUp += listBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label5.Location = new System.Drawing.Point(472, 29);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(109, 15);
            label5.TabIndex = 10;
            // 
            // Pitch0Button
            // 
            Pitch0Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Pitch0Button.Location = new System.Drawing.Point(4, 6);
            Pitch0Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 2);
            Pitch0Button.Name = "Pitch0Button";
            Pitch0Button.Size = new System.Drawing.Size(31, 24);
            Pitch0Button.TabIndex = 12;
            Pitch0Button.Text = "0.5";
            Pitch0Button.UseVisualStyleBackColor = true;
            Pitch0Button.Click += PitchButton_Click;
            // 
            // PitchBar
            // 
            PitchBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PitchBar.Location = new System.Drawing.Point(0, 4);
            PitchBar.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            PitchBar.Maximum = 100;
            PitchBar.Minimum = -100;
            PitchBar.Name = "PitchBar";
            PitchBar.Size = new System.Drawing.Size(210, 27);
            PitchBar.TabIndex = 13;
            PitchBar.TickFrequency = 10;
            PitchBar.Scroll += PitchBar_Scroll;
            PitchBar.MouseUp += PlayButton_Click;
            // 
            // Pitch1Button
            // 
            Pitch1Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            Pitch1Button.Location = new System.Drawing.Point(89, 6);
            Pitch1Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 2);
            Pitch1Button.Name = "Pitch1Button";
            Pitch1Button.Size = new System.Drawing.Size(31, 24);
            Pitch1Button.TabIndex = 14;
            Pitch1Button.Text = "1.0";
            Pitch1Button.UseVisualStyleBackColor = true;
            Pitch1Button.Click += PitchButton_Click;
            // 
            // Pitch2Button
            // 
            Pitch2Button.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            Pitch2Button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Pitch2Button.Location = new System.Drawing.Point(175, 6);
            Pitch2Button.Margin = new System.Windows.Forms.Padding(4, 6, 4, 2);
            Pitch2Button.Name = "Pitch2Button";
            Pitch2Button.Size = new System.Drawing.Size(31, 24);
            Pitch2Button.TabIndex = 15;
            Pitch2Button.Text = "2.0";
            Pitch2Button.UseVisualStyleBackColor = true;
            Pitch2Button.Click += PitchButton_Click;
            // 
            // PitchText
            // 
            PitchText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PitchText.Location = new System.Drawing.Point(214, 4);
            PitchText.Margin = new System.Windows.Forms.Padding(4);
            PitchText.Name = "PitchText";
            PitchText.Size = new System.Drawing.Size(57, 23);
            PitchText.TabIndex = 16;
            PitchText.Text = "1.0";
            PitchText.TextChanged += PitchText_TextChanged;
            // 
            // StopButton
            // 
            StopButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            StopButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StopButton.Location = new System.Drawing.Point(244, 2);
            StopButton.Margin = new System.Windows.Forms.Padding(2);
            StopButton.Name = "StopButton";
            StopButton.Size = new System.Drawing.Size(28, 28);
            StopButton.TabIndex = 18;
            StopButton.Text = "⬛";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // VolumeBar
            // 
            VolumeBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            VolumeBar.Location = new System.Drawing.Point(306, 6);
            VolumeBar.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            VolumeBar.Maximum = 100;
            VolumeBar.Minimum = -100;
            VolumeBar.Name = "VolumeBar";
            VolumeBar.Size = new System.Drawing.Size(75, 26);
            VolumeBar.TabIndex = 19;
            VolumeBar.TickFrequency = 0;
            VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            VolumeBar.Scroll += VolumeBar_Scroll;
            // 
            // CommandText
            // 
            CommandText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CommandText.Location = new System.Drawing.Point(379, 4);
            CommandText.Margin = new System.Windows.Forms.Padding(4);
            CommandText.Name = "CommandText";
            CommandText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CommandText.Size = new System.Drawing.Size(365, 23);
            CommandText.TabIndex = 20;
            // 
            // CopyButton
            // 
            CopyButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CopyButton.Location = new System.Drawing.Point(684, 2);
            CopyButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new System.Drawing.Size(60, 28);
            CopyButton.TabIndex = 21;
            CopyButton.Text = "Copy";
            CopyButton.UseVisualStyleBackColor = true;
            CopyButton.MouseUp += CopyButton_Click;
            // 
            // MuteButton
            // 
            MuteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            MuteButton.Appearance = System.Windows.Forms.Appearance.Button;
            MuteButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            MuteButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            MuteButton.Location = new System.Drawing.Point(276, 2);
            MuteButton.Margin = new System.Windows.Forms.Padding(2);
            MuteButton.Name = "MuteButton";
            MuteButton.Size = new System.Drawing.Size(28, 28);
            MuteButton.TabIndex = 22;
            MuteButton.Text = "🔊";
            MuteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            MuteButton.UseVisualStyleBackColor = true;
            MuteButton.CheckedChanged += CheckStateChanged;
            // 
            // pathPanel
            // 
            pathPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pathPanel.BackColor = System.Drawing.SystemColors.Control;
            pathPanel.ColumnCount = 7;
            pathPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            pathPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            pathPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            pathPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            pathPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            pathPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            pathPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            pathPanel.Controls.Add(listBox3, 2, 1);
            pathPanel.Controls.Add(listBox4, 3, 1);
            pathPanel.Controls.Add(listBox5, 4, 1);
            pathPanel.Controls.Add(listBox2, 1, 1);
            pathPanel.Controls.Add(listBox1, 0, 1);
            pathPanel.Controls.Add(label1, 0, 0);
            pathPanel.Controls.Add(label2, 1, 0);
            pathPanel.Controls.Add(label4, 3, 0);
            pathPanel.Controls.Add(label5, 4, 0);
            pathPanel.Controls.Add(label3, 2, 0);
            pathPanel.Controls.Add(label6, 6, 0);
            pathPanel.Controls.Add(listBox6, 6, 1);
            pathPanel.Controls.Add(button1, 0, 2);
            pathPanel.Location = new System.Drawing.Point(-1, -3);
            pathPanel.Margin = new System.Windows.Forms.Padding(4);
            pathPanel.Name = "pathPanel";
            pathPanel.RowCount = 3;
            pathPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            pathPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            pathPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            pathPanel.Size = new System.Drawing.Size(752, 240);
            pathPanel.TabIndex = 23;
            // 
            // listBox1
            // 
            listBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new System.Drawing.Point(4, 48);
            listBox1.Margin = new System.Windows.Forms.Padding(4);
            listBox1.Name = "listBox1";
            listBox1.Size = new System.Drawing.Size(109, 169);
            listBox1.TabIndex = 2;
            listBox1.Visible = false;
            listBox1.VisibleChanged += AdjustColumnWidthBasedOnListBoxContent;
            listBox1.MouseUp += listBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.Location = new System.Drawing.Point(639, 15);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(109, 29);
            label6.TabIndex = 12;
            label6.Text = ".ogg";
            label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            label6.Visible = false;
            // 
            // listBox6
            // 
            listBox6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new System.Drawing.Point(639, 48);
            listBox6.Margin = new System.Windows.Forms.Padding(4);
            listBox6.Name = "listBox6";
            listBox6.Size = new System.Drawing.Size(109, 169);
            listBox6.TabIndex = 11;
            listBox6.Visible = false;
            listBox6.VisibleChanged += AdjustColumnWidthBasedOnListBoxContent;
            listBox6.MouseUp += listBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            button1.BackColor = System.Drawing.SystemColors.HighlightText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.SystemColors.Window;
            button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            button1.Location = new System.Drawing.Point(0, 225);
            button1.Margin = new System.Windows.Forms.Padding(0);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(30, 15);
            button1.TabIndex = 13;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.Paint += button1_Paint;
            // 
            // comBottomPanel1
            // 
            comBottomPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comBottomPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            comBottomPanel1.ColumnCount = 4;
            comBottomPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            comBottomPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            comBottomPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            comBottomPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comBottomPanel1.Controls.Add(PitchBar, 0, 0);
            comBottomPanel1.Controls.Add(PitchText, 1, 0);
            comBottomPanel1.Controls.Add(comboBox2, 2, 0);
            comBottomPanel1.Controls.Add(CommandText, 3, 0);
            comBottomPanel1.Location = new System.Drawing.Point(0, 0);
            comBottomPanel1.Margin = new System.Windows.Forms.Padding(0);
            comBottomPanel1.Name = "comBottomPanel1";
            comBottomPanel1.RowCount = 1;
            comBottomPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comBottomPanel1.Size = new System.Drawing.Size(748, 31);
            comBottomPanel1.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(new object[] { "Command", "Path" });
            comboBox2.Location = new System.Drawing.Point(279, 4);
            comboBox2.Margin = new System.Windows.Forms.Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(92, 23);
            comboBox2.TabIndex = 21;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // PlayButton
            // 
            PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PlayButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PlayButton.Location = new System.Drawing.Point(212, 2);
            PlayButton.Margin = new System.Windows.Forms.Padding(2);
            PlayButton.Name = "PlayButton";
            PlayButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            PlayButton.Size = new System.Drawing.Size(28, 28);
            PlayButton.TabIndex = 17;
            PlayButton.Text = "▶";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // comBottomPanel2
            // 
            comBottomPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comBottomPanel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            comBottomPanel2.ColumnCount = 10;
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comBottomPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            comBottomPanel2.Controls.Add(Pitch1Button, 1, 0);
            comBottomPanel2.Controls.Add(Pitch2Button, 2, 0);
            comBottomPanel2.Controls.Add(StopButton, 4, 0);
            comBottomPanel2.Controls.Add(PlayButton, 3, 0);
            comBottomPanel2.Controls.Add(VolumeBar, 6, 0);
            comBottomPanel2.Controls.Add(MuteButton, 5, 0);
            comBottomPanel2.Controls.Add(Pitch0Button, 0, 0);
            comBottomPanel2.Controls.Add(CopyButton, 9, 0);
            comBottomPanel2.Controls.Add(checkBoxPanel, 7, 0);
            comBottomPanel2.Location = new System.Drawing.Point(0, 31);
            comBottomPanel2.Margin = new System.Windows.Forms.Padding(0);
            comBottomPanel2.Name = "comBottomPanel2";
            comBottomPanel2.RowCount = 1;
            comBottomPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comBottomPanel2.Size = new System.Drawing.Size(748, 32);
            comBottomPanel2.TabIndex = 25;
            // 
            // checkBoxPanel
            // 
            checkBoxPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            checkBoxPanel.ColumnCount = 2;
            checkBoxPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            checkBoxPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            checkBoxPanel.Controls.Add(playCheckboxParameter, 0, 0);
            checkBoxPanel.Controls.Add(playCheckboxNotSelected, 1, 0);
            checkBoxPanel.Controls.Add(playCheckboxSelected, 0, 1);
            checkBoxPanel.Location = new System.Drawing.Point(381, 0);
            checkBoxPanel.Margin = new System.Windows.Forms.Padding(0);
            checkBoxPanel.Name = "checkBoxPanel";
            checkBoxPanel.RowCount = 2;
            checkBoxPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            checkBoxPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            checkBoxPanel.Size = new System.Drawing.Size(180, 32);
            checkBoxPanel.TabIndex = 23;
            // 
            // playCheckboxParameter
            // 
            playCheckboxParameter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            playCheckboxParameter.AutoSize = true;
            playCheckboxParameter.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            playCheckboxParameter.Location = new System.Drawing.Point(0, 0);
            playCheckboxParameter.Margin = new System.Windows.Forms.Padding(0);
            playCheckboxParameter.Name = "playCheckboxParameter";
            playCheckboxParameter.Size = new System.Drawing.Size(90, 16);
            playCheckboxParameter.TabIndex = 2;
            playCheckboxParameter.Text = "Parameter";
            playCheckboxParameter.UseVisualStyleBackColor = true;
            // 
            // playCheckboxNotSelected
            // 
            playCheckboxNotSelected.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            playCheckboxNotSelected.AutoSize = true;
            playCheckboxNotSelected.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            playCheckboxNotSelected.Location = new System.Drawing.Point(90, 0);
            playCheckboxNotSelected.Margin = new System.Windows.Forms.Padding(0);
            playCheckboxNotSelected.Name = "playCheckboxNotSelected";
            playCheckboxNotSelected.Size = new System.Drawing.Size(90, 16);
            playCheckboxNotSelected.TabIndex = 1;
            playCheckboxNotSelected.Text = "NotSelected";
            playCheckboxNotSelected.UseVisualStyleBackColor = true;
            // 
            // playCheckboxSelected
            // 
            playCheckboxSelected.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            playCheckboxSelected.AutoSize = true;
            playCheckboxSelected.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            playCheckboxSelected.Location = new System.Drawing.Point(0, 16);
            playCheckboxSelected.Margin = new System.Windows.Forms.Padding(0);
            playCheckboxSelected.Name = "playCheckboxSelected";
            playCheckboxSelected.Size = new System.Drawing.Size(90, 16);
            playCheckboxSelected.TabIndex = 0;
            playCheckboxSelected.Text = "Selected";
            playCheckboxSelected.UseVisualStyleBackColor = true;
            // 
            // comPanel
            // 
            comPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            comPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            comPanel.ColumnCount = 1;
            comPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            comPanel.Controls.Add(comUpPanel, 0, 0);
            comPanel.Controls.Add(comBottomPanel, 0, 1);
            comPanel.Location = new System.Drawing.Point(-1, 245);
            comPanel.Margin = new System.Windows.Forms.Padding(4);
            comPanel.Name = "comPanel";
            comPanel.RowCount = 2;
            comPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            comPanel.Size = new System.Drawing.Size(753, 251);
            comPanel.TabIndex = 24;
            // 
            // comUpPanel
            // 
            comUpPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comUpPanel.ColumnCount = 3;
            comUpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.64246F));
            comUpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.3575439F));
            comUpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            comUpPanel.Controls.Add(comParasPanel, 0, 0);
            comUpPanel.Controls.Add(comSavePanel, 2, 0);
            comUpPanel.Controls.Add(listBox_coms, 1, 0);
            comUpPanel.Location = new System.Drawing.Point(4, 4);
            comUpPanel.Name = "comUpPanel";
            comUpPanel.RowCount = 1;
            comUpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comUpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            comUpPanel.Size = new System.Drawing.Size(757, 173);
            comUpPanel.TabIndex = 1;
            // 
            // comParasPanel
            // 
            comParasPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comParasPanel.ColumnCount = 1;
            comParasPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comParasPanel.Controls.Add(comVolminPanel, 0, 5);
            comParasPanel.Controls.Add(comFilePanel, 0, 0);
            comParasPanel.Controls.Add(comPara_source, 0, 1);
            comParasPanel.Controls.Add(comPara_selector, 0, 2);
            comParasPanel.Controls.Add(comPosPanel, 0, 3);
            comParasPanel.Controls.Add(comVolPanel, 0, 4);
            comParasPanel.Location = new System.Drawing.Point(3, 3);
            comParasPanel.Name = "comParasPanel";
            comParasPanel.RowCount = 7;
            comParasPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            comParasPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            comParasPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            comParasPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            comParasPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66222F));
            comParasPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66222F));
            comParasPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            comParasPanel.Size = new System.Drawing.Size(106, 167);
            comParasPanel.TabIndex = 1;
            // 
            // comVolminPanel
            // 
            comVolminPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comVolminPanel.ColumnCount = 2;
            comVolminPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            comVolminPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            comVolminPanel.Controls.Add(comPara_volmin, 0, 0);
            comVolminPanel.Controls.Add(comPara_volmin_bar, 1, 0);
            comVolminPanel.Location = new System.Drawing.Point(0, 135);
            comVolminPanel.Margin = new System.Windows.Forms.Padding(0);
            comVolminPanel.Name = "comVolminPanel";
            comVolminPanel.RowCount = 1;
            comVolminPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comVolminPanel.Size = new System.Drawing.Size(106, 27);
            comVolminPanel.TabIndex = 5;
            // 
            // comPara_volmin
            // 
            comPara_volmin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_volmin.Location = new System.Drawing.Point(1, 1);
            comPara_volmin.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            comPara_volmin.Name = "comPara_volmin";
            comPara_volmin.Size = new System.Drawing.Size(30, 23);
            comPara_volmin.TabIndex = 0;
            comPara_volmin.Text = " ";
            comPara_volmin.TextChanged += comPara_volmin_TextChanged;
            // 
            // comPara_volmin_bar
            // 
            comPara_volmin_bar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_volmin_bar.Location = new System.Drawing.Point(31, 0);
            comPara_volmin_bar.Margin = new System.Windows.Forms.Padding(0);
            comPara_volmin_bar.Name = "comPara_volmin_bar";
            comPara_volmin_bar.Size = new System.Drawing.Size(75, 27);
            comPara_volmin_bar.TabIndex = 1;
            comPara_volmin_bar.Scroll += comPara_volmin_bar_Scroll;
            // 
            // comFilePanel
            // 
            comFilePanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comFilePanel.ColumnCount = 3;
            comFilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comFilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            comFilePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            comFilePanel.Controls.Add(comsList_save, 2, 0);
            comFilePanel.Controls.Add(comPara_selectedFile, 0, 0);
            comFilePanel.Controls.Add(button_selectFile, 1, 0);
            comFilePanel.Location = new System.Drawing.Point(0, 0);
            comFilePanel.Margin = new System.Windows.Forms.Padding(0);
            comFilePanel.Name = "comFilePanel";
            comFilePanel.RowCount = 1;
            comFilePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comFilePanel.Size = new System.Drawing.Size(106, 27);
            comFilePanel.TabIndex = 0;
            // 
            // comsList_save
            // 
            comsList_save.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comsList_save.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comsList_save.Location = new System.Drawing.Point(82, 1);
            comsList_save.Margin = new System.Windows.Forms.Padding(1);
            comsList_save.Name = "comsList_save";
            comsList_save.Size = new System.Drawing.Size(23, 25);
            comsList_save.TabIndex = 2;
            comsList_save.Text = "💾";
            comsList_save.UseVisualStyleBackColor = true;
            comsList_save.Click += comsList_save_Click;
            // 
            // comPara_selectedFile
            // 
            comPara_selectedFile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_selectedFile.Location = new System.Drawing.Point(1, 1);
            comPara_selectedFile.Margin = new System.Windows.Forms.Padding(1);
            comPara_selectedFile.Name = "comPara_selectedFile";
            comPara_selectedFile.Size = new System.Drawing.Size(53, 23);
            comPara_selectedFile.TabIndex = 0;
            // 
            // button_selectFile
            // 
            button_selectFile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            button_selectFile.Location = new System.Drawing.Point(56, 6);
            button_selectFile.Margin = new System.Windows.Forms.Padding(1, 6, 1, 1);
            button_selectFile.Name = "button_selectFile";
            button_selectFile.Size = new System.Drawing.Size(24, 20);
            button_selectFile.TabIndex = 1;
            button_selectFile.Text = "...";
            button_selectFile.UseVisualStyleBackColor = true;
            button_selectFile.Click += button_selectFile_Click;
            // 
            // comPara_source
            // 
            comPara_source.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_source.FormattingEnabled = true;
            comPara_source.Location = new System.Drawing.Point(1, 28);
            comPara_source.Margin = new System.Windows.Forms.Padding(1);
            comPara_source.Name = "comPara_source";
            comPara_source.Size = new System.Drawing.Size(104, 23);
            comPara_source.TabIndex = 1;
            comPara_source.TextUpdate += comPara_TextUpdate;
            // 
            // comPara_selector
            // 
            comPara_selector.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_selector.Location = new System.Drawing.Point(1, 55);
            comPara_selector.Margin = new System.Windows.Forms.Padding(1);
            comPara_selector.Name = "comPara_selector";
            comPara_selector.Size = new System.Drawing.Size(104, 23);
            comPara_selector.TabIndex = 2;
            comPara_selector.TextChanged += comPara_TextUpdate;
            // 
            // comPosPanel
            // 
            comPosPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPosPanel.ColumnCount = 3;
            comPosPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            comPosPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            comPosPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            comPosPanel.Controls.Add(comPara_posx, 0, 0);
            comPosPanel.Controls.Add(comPara_posy, 1, 0);
            comPosPanel.Controls.Add(comPara_posz, 2, 0);
            comPosPanel.Location = new System.Drawing.Point(0, 81);
            comPosPanel.Margin = new System.Windows.Forms.Padding(0);
            comPosPanel.Name = "comPosPanel";
            comPosPanel.RowCount = 1;
            comPosPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comPosPanel.Size = new System.Drawing.Size(106, 27);
            comPosPanel.TabIndex = 3;
            // 
            // comPara_posx
            // 
            comPara_posx.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_posx.Location = new System.Drawing.Point(1, 1);
            comPara_posx.Margin = new System.Windows.Forms.Padding(1);
            comPara_posx.Name = "comPara_posx";
            comPara_posx.Size = new System.Drawing.Size(33, 23);
            comPara_posx.TabIndex = 0;
            comPara_posx.TextChanged += comPara_TextUpdate;
            // 
            // comPara_posy
            // 
            comPara_posy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_posy.Location = new System.Drawing.Point(36, 1);
            comPara_posy.Margin = new System.Windows.Forms.Padding(1);
            comPara_posy.Name = "comPara_posy";
            comPara_posy.Size = new System.Drawing.Size(33, 23);
            comPara_posy.TabIndex = 1;
            comPara_posy.TextChanged += comPara_TextUpdate;
            // 
            // comPara_posz
            // 
            comPara_posz.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_posz.Location = new System.Drawing.Point(71, 1);
            comPara_posz.Margin = new System.Windows.Forms.Padding(1);
            comPara_posz.Name = "comPara_posz";
            comPara_posz.Size = new System.Drawing.Size(34, 23);
            comPara_posz.TabIndex = 2;
            comPara_posz.TextChanged += comPara_TextUpdate;
            // 
            // comVolPanel
            // 
            comVolPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comVolPanel.ColumnCount = 2;
            comVolPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            comVolPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            comVolPanel.Controls.Add(comPara_vol, 0, 0);
            comVolPanel.Controls.Add(comPara_vol_bar, 1, 0);
            comVolPanel.Location = new System.Drawing.Point(0, 108);
            comVolPanel.Margin = new System.Windows.Forms.Padding(0);
            comVolPanel.Name = "comVolPanel";
            comVolPanel.RowCount = 1;
            comVolPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comVolPanel.Size = new System.Drawing.Size(106, 27);
            comVolPanel.TabIndex = 4;
            // 
            // comPara_vol
            // 
            comPara_vol.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_vol.Location = new System.Drawing.Point(1, 1);
            comPara_vol.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            comPara_vol.Name = "comPara_vol";
            comPara_vol.Size = new System.Drawing.Size(30, 23);
            comPara_vol.TabIndex = 0;
            comPara_vol.TextChanged += comPara_vol_TextChanged;
            // 
            // comPara_vol_bar
            // 
            comPara_vol_bar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_vol_bar.Location = new System.Drawing.Point(31, 0);
            comPara_vol_bar.Margin = new System.Windows.Forms.Padding(0);
            comPara_vol_bar.Name = "comPara_vol_bar";
            comPara_vol_bar.Size = new System.Drawing.Size(75, 27);
            comPara_vol_bar.TabIndex = 1;
            comPara_vol_bar.Value = 10;
            comPara_vol_bar.Scroll += comPara_vol_bar_Scroll;
            // 
            // comSavePanel
            // 
            comSavePanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comSavePanel.ColumnCount = 1;
            comSavePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comSavePanel.Controls.Add(comsList_moveUp, 0, 4);
            comSavePanel.Controls.Add(comsList_moveDown, 0, 5);
            comSavePanel.Controls.Add(comsList_remove, 0, 2);
            comSavePanel.Controls.Add(comsList_add, 0, 1);
            comSavePanel.Controls.Add(comsList_rewrite, 0, 0);
            comSavePanel.Location = new System.Drawing.Point(716, 0);
            comSavePanel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            comSavePanel.Name = "comSavePanel";
            comSavePanel.RowCount = 6;
            comSavePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            comSavePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            comSavePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            comSavePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            comSavePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            comSavePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            comSavePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            comSavePanel.Size = new System.Drawing.Size(31, 173);
            comSavePanel.TabIndex = 2;
            // 
            // comsList_moveUp
            // 
            comsList_moveUp.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comsList_moveUp.Location = new System.Drawing.Point(2, 115);
            comsList_moveUp.Margin = new System.Windows.Forms.Padding(2);
            comsList_moveUp.Name = "comsList_moveUp";
            comsList_moveUp.Size = new System.Drawing.Size(27, 26);
            comsList_moveUp.TabIndex = 3;
            comsList_moveUp.Text = "▲";
            comsList_moveUp.UseVisualStyleBackColor = true;
            comsList_moveUp.Click += comsList_moveUp_Click;
            // 
            // comsList_moveDown
            // 
            comsList_moveDown.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comsList_moveDown.Location = new System.Drawing.Point(2, 145);
            comsList_moveDown.Margin = new System.Windows.Forms.Padding(2);
            comsList_moveDown.Name = "comsList_moveDown";
            comsList_moveDown.Size = new System.Drawing.Size(27, 26);
            comsList_moveDown.TabIndex = 4;
            comsList_moveDown.Text = "▼";
            comsList_moveDown.UseVisualStyleBackColor = true;
            comsList_moveDown.Click += comsList_moveDown_Click;
            // 
            // comsList_remove
            // 
            comsList_remove.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comsList_remove.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comsList_remove.Location = new System.Drawing.Point(2, 62);
            comsList_remove.Margin = new System.Windows.Forms.Padding(2);
            comsList_remove.Name = "comsList_remove";
            comsList_remove.Size = new System.Drawing.Size(27, 26);
            comsList_remove.TabIndex = 1;
            comsList_remove.Text = "➖";
            comsList_remove.UseVisualStyleBackColor = true;
            comsList_remove.Click += comsList_remove_Click;
            // 
            // comsList_add
            // 
            comsList_add.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comsList_add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            comsList_add.Location = new System.Drawing.Point(2, 32);
            comsList_add.Margin = new System.Windows.Forms.Padding(2);
            comsList_add.Name = "comsList_add";
            comsList_add.Size = new System.Drawing.Size(27, 26);
            comsList_add.TabIndex = 0;
            comsList_add.Text = "➕";
            comsList_add.UseVisualStyleBackColor = true;
            comsList_add.Click += comsList_add_Click;
            // 
            // comsList_rewrite
            // 
            comsList_rewrite.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comsList_rewrite.Location = new System.Drawing.Point(2, 2);
            comsList_rewrite.Margin = new System.Windows.Forms.Padding(2);
            comsList_rewrite.Name = "comsList_rewrite";
            comsList_rewrite.Size = new System.Drawing.Size(27, 26);
            comsList_rewrite.TabIndex = 5;
            comsList_rewrite.Text = "◀";
            comsList_rewrite.UseVisualStyleBackColor = true;
            comsList_rewrite.Click += comsList_rewrite_Click;
            // 
            // listBox_coms
            // 
            listBox_coms.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox_coms.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            listBox_coms.FormattingEnabled = true;
            listBox_coms.ItemHeight = 15;
            listBox_coms.Location = new System.Drawing.Point(114, 2);
            listBox_coms.Margin = new System.Windows.Forms.Padding(2);
            listBox_coms.Name = "listBox_coms";
            listBox_coms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            listBox_coms.Size = new System.Drawing.Size(600, 169);
            listBox_coms.TabIndex = 0;
            listBox_coms.DrawItem += listBox_coms_DrawItem;
            listBox_coms.DataSourceChanged += listBox_coms_DataSourceChanged;
            listBox_coms.DoubleClick += listBox_coms_DoubleClick;
            listBox_coms.MouseUp += listBox_coms_MouseUp;
            // 
            // comBottomPanel
            // 
            comBottomPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comBottomPanel.ColumnCount = 1;
            comBottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            comBottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            comBottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            comBottomPanel.Controls.Add(comBottomPanel2, 0, 1);
            comBottomPanel.Controls.Add(comBottomPanel1, 0, 0);
            comBottomPanel.Location = new System.Drawing.Point(4, 184);
            comBottomPanel.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            comBottomPanel.Name = "comBottomPanel";
            comBottomPanel.RowCount = 2;
            comBottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            comBottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            comBottomPanel.Size = new System.Drawing.Size(748, 63);
            comBottomPanel.TabIndex = 0;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.FileName = "favorites.mcfunction";
            saveFileDialog1.Filter = "mcfunction Files (*.mcfunction)|*.mcfunction|All Files (*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveBorder;
            ClientSize = new System.Drawing.Size(751, 495);
            Controls.Add(comboBox1);
            Controls.Add(pathPanel);
            Controls.Add(comPanel);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Playsounder";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PitchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).EndInit();
            pathPanel.ResumeLayout(false);
            comBottomPanel1.ResumeLayout(false);
            comBottomPanel1.PerformLayout();
            comBottomPanel2.ResumeLayout(false);
            comBottomPanel2.PerformLayout();
            checkBoxPanel.ResumeLayout(false);
            checkBoxPanel.PerformLayout();
            comPanel.ResumeLayout(false);
            comUpPanel.ResumeLayout(false);
            comParasPanel.ResumeLayout(false);
            comParasPanel.PerformLayout();
            comVolminPanel.ResumeLayout(false);
            comVolminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comPara_volmin_bar).EndInit();
            comFilePanel.ResumeLayout(false);
            comFilePanel.PerformLayout();
            comPosPanel.ResumeLayout(false);
            comPosPanel.PerformLayout();
            comVolPanel.ResumeLayout(false);
            comVolPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comPara_vol_bar).EndInit();
            comSavePanel.ResumeLayout(false);
            comBottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Pitch0Button;
        private System.Windows.Forms.TrackBar PitchBar;
        private System.Windows.Forms.Button Pitch1Button;
        private System.Windows.Forms.Button Pitch2Button;
        private System.Windows.Forms.TextBox PitchText;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TrackBar VolumeBar;
        private System.Windows.Forms.TextBox CommandText;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.CheckBox MuteButton;
        private System.Windows.Forms.TableLayoutPanel pathPanel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel comBottomPanel1;
        private System.Windows.Forms.TableLayoutPanel comBottomPanel2;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TableLayoutPanel comPanel;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel comBottomPanel;
        private System.Windows.Forms.TableLayoutPanel comUpPanel;
        private System.Windows.Forms.ListBox listBox_coms;
        private System.Windows.Forms.TableLayoutPanel comParasPanel;
        private System.Windows.Forms.TableLayoutPanel comFilePanel;
        private System.Windows.Forms.TextBox comPara_selectedFile;
        private System.Windows.Forms.Button button_selectFile;
        private System.Windows.Forms.ComboBox comPara_source;
        private System.Windows.Forms.TextBox comPara_selector;
        private System.Windows.Forms.TableLayoutPanel comPosPanel;
        private System.Windows.Forms.TextBox comPara_posx;
        private System.Windows.Forms.TextBox comPara_posy;
        private System.Windows.Forms.TextBox comPara_posz;
        private System.Windows.Forms.TableLayoutPanel comVolPanel;
        private System.Windows.Forms.TextBox comPara_vol;
        private System.Windows.Forms.TableLayoutPanel comVolminPanel;
        private System.Windows.Forms.TextBox comPara_volmin;
        private System.Windows.Forms.TrackBar comPara_volmin_bar;
        private System.Windows.Forms.TrackBar comPara_vol_bar;
        private System.Windows.Forms.TableLayoutPanel comSavePanel;
        private System.Windows.Forms.Button comsList_add;
        private System.Windows.Forms.Button comsList_remove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button comsList_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button comsList_moveUp;
        private System.Windows.Forms.Button comsList_moveDown;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TableLayoutPanel checkBoxPanel;
        private System.Windows.Forms.CheckBox playCheckboxSelected;
        private System.Windows.Forms.CheckBox playCheckboxNotSelected;
        private System.Windows.Forms.CheckBox playCheckboxParameter;
        private System.Windows.Forms.Button comsList_rewrite;
    }
}

