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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            listBox1 = new System.Windows.Forms.ListBox();
            label6 = new System.Windows.Forms.Label();
            listBox6 = new System.Windows.Forms.ListBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            comboBox2 = new System.Windows.Forms.ComboBox();
            PlayButton = new System.Windows.Forms.Button();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            comPara_volmin = new System.Windows.Forms.TextBox();
            comPara_volmin_bar = new System.Windows.Forms.TrackBar();
            tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            textBox_selectedFile = new System.Windows.Forms.TextBox();
            button_selectFile = new System.Windows.Forms.Button();
            comPara_source = new System.Windows.Forms.ComboBox();
            comPara_selector = new System.Windows.Forms.TextBox();
            tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            comPara_posx = new System.Windows.Forms.TextBox();
            comPara_posy = new System.Windows.Forms.TextBox();
            comPara_posz = new System.Windows.Forms.TextBox();
            tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            comPara_vol = new System.Windows.Forms.TextBox();
            comPara_vol_bar = new System.Windows.Forms.TrackBar();
            listBox_coms = new System.Windows.Forms.ListBox();
            tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            coms_plus = new System.Windows.Forms.Button();
            coms_minus = new System.Windows.Forms.Button();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)PitchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comPara_volmin_bar).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)comPara_vol_bar).BeginInit();
            tableLayoutPanel12.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.Location = new System.Drawing.Point(4, 4);
            comboBox1.Margin = new System.Windows.Forms.Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(97, 23);
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
            Pitch0Button.Size = new System.Drawing.Size(31, 21);
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
            PitchBar.Size = new System.Drawing.Size(210, 24);
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
            Pitch1Button.Size = new System.Drawing.Size(31, 21);
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
            Pitch2Button.Size = new System.Drawing.Size(31, 21);
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
            PitchText.Size = new System.Drawing.Size(51, 23);
            PitchText.TabIndex = 16;
            PitchText.Text = "1.0";
            PitchText.TextChanged += PitchText_TextChanged;
            // 
            // StopButton
            // 
            StopButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            StopButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StopButton.Location = new System.Drawing.Point(243, 2);
            StopButton.Margin = new System.Windows.Forms.Padding(2);
            StopButton.Name = "StopButton";
            StopButton.Size = new System.Drawing.Size(27, 25);
            StopButton.TabIndex = 18;
            StopButton.Text = "⬛";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // VolumeBar
            // 
            VolumeBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            VolumeBar.Location = new System.Drawing.Point(303, 5);
            VolumeBar.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            VolumeBar.Maximum = 100;
            VolumeBar.Minimum = -100;
            VolumeBar.Name = "VolumeBar";
            VolumeBar.Size = new System.Drawing.Size(80, 24);
            VolumeBar.TabIndex = 19;
            VolumeBar.TickFrequency = 0;
            VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            VolumeBar.Scroll += VolumeBar_Scroll;
            // 
            // CommandText
            // 
            CommandText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CommandText.Location = new System.Drawing.Point(371, 4);
            CommandText.Margin = new System.Windows.Forms.Padding(4);
            CommandText.Name = "CommandText";
            CommandText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CommandText.Size = new System.Drawing.Size(377, 23);
            CommandText.TabIndex = 20;
            // 
            // CopyButton
            // 
            CopyButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CopyButton.Location = new System.Drawing.Point(703, 2);
            CopyButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new System.Drawing.Size(45, 25);
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
            MuteButton.Location = new System.Drawing.Point(274, 2);
            MuteButton.Margin = new System.Windows.Forms.Padding(2);
            MuteButton.Name = "MuteButton";
            MuteButton.Size = new System.Drawing.Size(27, 25);
            MuteButton.TabIndex = 22;
            MuteButton.Text = "🔊";
            MuteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            MuteButton.UseVisualStyleBackColor = true;
            MuteButton.CheckedChanged += CheckStateChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            tableLayoutPanel1.Controls.Add(listBox3, 2, 1);
            tableLayoutPanel1.Controls.Add(listBox4, 3, 1);
            tableLayoutPanel1.Controls.Add(listBox5, 4, 1);
            tableLayoutPanel1.Controls.Add(listBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(label5, 4, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label6, 6, 0);
            tableLayoutPanel1.Controls.Add(listBox6, 6, 1);
            tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(743, 234);
            tableLayoutPanel1.TabIndex = 23;
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
            label6.Location = new System.Drawing.Point(630, 15);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(109, 29);
            label6.TabIndex = 12;
            label6.Text = "ogg files";
            label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            label6.Visible = false;
            // 
            // listBox6
            // 
            listBox6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox6.FormattingEnabled = true;
            listBox6.ItemHeight = 15;
            listBox6.Location = new System.Drawing.Point(630, 48);
            listBox6.Margin = new System.Windows.Forms.Padding(4);
            listBox6.Name = "listBox6";
            listBox6.Size = new System.Drawing.Size(109, 169);
            listBox6.TabIndex = 11;
            listBox6.Visible = false;
            listBox6.VisibleChanged += AdjustColumnWidthBasedOnListBoxContent;
            listBox6.MouseUp += listBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.94092F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.16193F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.11597F));
            tableLayoutPanel3.Controls.Add(PitchBar, 0, 0);
            tableLayoutPanel3.Controls.Add(PitchText, 1, 0);
            tableLayoutPanel3.Controls.Add(comboBox2, 2, 0);
            tableLayoutPanel3.Controls.Add(CommandText, 3, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(752, 28);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(new object[] { "Command", "Path" });
            comboBox2.Location = new System.Drawing.Point(273, 4);
            comboBox2.Margin = new System.Windows.Forms.Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(90, 23);
            comboBox2.TabIndex = 21;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // PlayButton
            // 
            PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PlayButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PlayButton.Location = new System.Drawing.Point(214, 2);
            PlayButton.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            PlayButton.Name = "PlayButton";
            PlayButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            PlayButton.Size = new System.Drawing.Size(25, 25);
            PlayButton.TabIndex = 17;
            PlayButton.Text = "▶";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            tableLayoutPanel4.ColumnCount = 8;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 369F));
            tableLayoutPanel4.Controls.Add(Pitch1Button, 1, 0);
            tableLayoutPanel4.Controls.Add(Pitch2Button, 2, 0);
            tableLayoutPanel4.Controls.Add(StopButton, 4, 0);
            tableLayoutPanel4.Controls.Add(PlayButton, 3, 0);
            tableLayoutPanel4.Controls.Add(CopyButton, 7, 0);
            tableLayoutPanel4.Controls.Add(VolumeBar, 6, 0);
            tableLayoutPanel4.Controls.Add(MuteButton, 5, 0);
            tableLayoutPanel4.Controls.Add(Pitch0Button, 0, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(0, 28);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(752, 29);
            tableLayoutPanel4.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel2.Location = new System.Drawing.Point(-8, 242);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            tableLayoutPanel2.Size = new System.Drawing.Size(768, 232);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(listBox_coms, 1, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel12, 2, 0);
            tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new System.Drawing.Size(766, 160);
            tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel11, 0, 5);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel7.Controls.Add(comPara_source, 0, 1);
            tableLayoutPanel7.Controls.Add(comPara_selector, 0, 2);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel9, 0, 3);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel10, 0, 4);
            tableLayoutPanel7.Location = new System.Drawing.Point(8, 3);
            tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 7;
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66222F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66222F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel7.Size = new System.Drawing.Size(133, 154);
            tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel11.ColumnCount = 2;
            tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0769234F));
            tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            tableLayoutPanel11.Controls.Add(comPara_volmin, 0, 0);
            tableLayoutPanel11.Controls.Add(comPara_volmin_bar, 1, 0);
            tableLayoutPanel11.Location = new System.Drawing.Point(0, 125);
            tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 1;
            tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel11.Size = new System.Drawing.Size(133, 25);
            tableLayoutPanel11.TabIndex = 5;
            // 
            // comPara_volmin
            // 
            comPara_volmin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_volmin.Location = new System.Drawing.Point(1, 1);
            comPara_volmin.Margin = new System.Windows.Forms.Padding(1);
            comPara_volmin.Name = "comPara_volmin";
            comPara_volmin.Size = new System.Drawing.Size(28, 23);
            comPara_volmin.TabIndex = 0;
            // 
            // comPara_volmin_bar
            // 
            comPara_volmin_bar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_volmin_bar.Location = new System.Drawing.Point(31, 1);
            comPara_volmin_bar.Margin = new System.Windows.Forms.Padding(1);
            comPara_volmin_bar.Name = "comPara_volmin_bar";
            comPara_volmin_bar.Size = new System.Drawing.Size(101, 23);
            comPara_volmin_bar.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            tableLayoutPanel8.Controls.Add(textBox_selectedFile, 0, 0);
            tableLayoutPanel8.Controls.Add(button_selectFile, 1, 0);
            tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new System.Drawing.Size(133, 25);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // textBox_selectedFile
            // 
            textBox_selectedFile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBox_selectedFile.Location = new System.Drawing.Point(1, 1);
            textBox_selectedFile.Margin = new System.Windows.Forms.Padding(1);
            textBox_selectedFile.Name = "textBox_selectedFile";
            textBox_selectedFile.Size = new System.Drawing.Size(105, 23);
            textBox_selectedFile.TabIndex = 0;
            // 
            // button_selectFile
            // 
            button_selectFile.Location = new System.Drawing.Point(108, 1);
            button_selectFile.Margin = new System.Windows.Forms.Padding(1);
            button_selectFile.Name = "button_selectFile";
            button_selectFile.Size = new System.Drawing.Size(24, 23);
            button_selectFile.TabIndex = 1;
            button_selectFile.Text = "...";
            button_selectFile.UseVisualStyleBackColor = true;
            // 
            // comPara_source
            // 
            comPara_source.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_source.FormattingEnabled = true;
            comPara_source.Location = new System.Drawing.Point(1, 26);
            comPara_source.Margin = new System.Windows.Forms.Padding(1);
            comPara_source.Name = "comPara_source";
            comPara_source.Size = new System.Drawing.Size(131, 23);
            comPara_source.TabIndex = 1;
            // 
            // comPara_selector
            // 
            comPara_selector.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_selector.Location = new System.Drawing.Point(1, 51);
            comPara_selector.Margin = new System.Windows.Forms.Padding(1);
            comPara_selector.Name = "comPara_selector";
            comPara_selector.Size = new System.Drawing.Size(131, 23);
            comPara_selector.TabIndex = 2;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Controls.Add(comPara_posx, 0, 0);
            tableLayoutPanel9.Controls.Add(comPara_posy, 1, 0);
            tableLayoutPanel9.Controls.Add(comPara_posz, 2, 0);
            tableLayoutPanel9.Location = new System.Drawing.Point(0, 75);
            tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new System.Drawing.Size(133, 25);
            tableLayoutPanel9.TabIndex = 3;
            // 
            // comPara_posx
            // 
            comPara_posx.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_posx.Location = new System.Drawing.Point(1, 1);
            comPara_posx.Margin = new System.Windows.Forms.Padding(1);
            comPara_posx.Name = "comPara_posx";
            comPara_posx.Size = new System.Drawing.Size(42, 23);
            comPara_posx.TabIndex = 0;
            // 
            // comPara_posy
            // 
            comPara_posy.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_posy.Location = new System.Drawing.Point(45, 1);
            comPara_posy.Margin = new System.Windows.Forms.Padding(1);
            comPara_posy.Name = "comPara_posy";
            comPara_posy.Size = new System.Drawing.Size(42, 23);
            comPara_posy.TabIndex = 1;
            // 
            // comPara_posz
            // 
            comPara_posz.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_posz.Location = new System.Drawing.Point(89, 1);
            comPara_posz.Margin = new System.Windows.Forms.Padding(1);
            comPara_posz.Name = "comPara_posz";
            comPara_posz.Size = new System.Drawing.Size(43, 23);
            comPara_posz.TabIndex = 2;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.0769234F));
            tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.92308F));
            tableLayoutPanel10.Controls.Add(comPara_vol, 0, 0);
            tableLayoutPanel10.Controls.Add(comPara_vol_bar, 1, 0);
            tableLayoutPanel10.Location = new System.Drawing.Point(0, 100);
            tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel10.Size = new System.Drawing.Size(133, 25);
            tableLayoutPanel10.TabIndex = 4;
            // 
            // comPara_vol
            // 
            comPara_vol.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_vol.Location = new System.Drawing.Point(1, 1);
            comPara_vol.Margin = new System.Windows.Forms.Padding(1);
            comPara_vol.Name = "comPara_vol";
            comPara_vol.Size = new System.Drawing.Size(28, 23);
            comPara_vol.TabIndex = 0;
            // 
            // comPara_vol_bar
            // 
            comPara_vol_bar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comPara_vol_bar.Location = new System.Drawing.Point(31, 1);
            comPara_vol_bar.Margin = new System.Windows.Forms.Padding(1);
            comPara_vol_bar.Name = "comPara_vol_bar";
            comPara_vol_bar.Size = new System.Drawing.Size(101, 23);
            comPara_vol_bar.TabIndex = 1;
            // 
            // listBox_coms
            // 
            listBox_coms.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            listBox_coms.FormattingEnabled = true;
            listBox_coms.ItemHeight = 15;
            listBox_coms.Location = new System.Drawing.Point(147, 3);
            listBox_coms.Name = "listBox_coms";
            listBox_coms.Size = new System.Drawing.Size(570, 154);
            listBox_coms.TabIndex = 0;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel12.ColumnCount = 1;
            tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(coms_plus, 0, 1);
            tableLayoutPanel12.Controls.Add(coms_minus, 0, 2);
            tableLayoutPanel12.Location = new System.Drawing.Point(720, 0);
            tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(0, 0, 15, 0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 3;
            tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableLayoutPanel12.Size = new System.Drawing.Size(31, 160);
            tableLayoutPanel12.TabIndex = 2;
            // 
            // coms_plus
            // 
            coms_plus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            coms_plus.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            coms_plus.Location = new System.Drawing.Point(2, 102);
            coms_plus.Margin = new System.Windows.Forms.Padding(2);
            coms_plus.Name = "coms_plus";
            coms_plus.Size = new System.Drawing.Size(27, 26);
            coms_plus.TabIndex = 0;
            coms_plus.Text = "+";
            coms_plus.UseVisualStyleBackColor = true;
            // 
            // coms_minus
            // 
            coms_minus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            coms_minus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            coms_minus.Location = new System.Drawing.Point(2, 132);
            coms_minus.Margin = new System.Windows.Forms.Padding(2);
            coms_minus.Name = "coms_minus";
            coms_minus.Size = new System.Drawing.Size(27, 26);
            coms_minus.TabIndex = 1;
            coms_minus.Text = "➖";
            coms_minus.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel5.Location = new System.Drawing.Point(9, 171);
            tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(8, 3, 12, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new System.Drawing.Size(752, 57);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(751, 473);
            Controls.Add(comboBox1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            Name = "Form1";
            Text = "Playsounder";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PitchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comPara_volmin_bar).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)comPara_vol_bar).EndInit();
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ListBox listBox_coms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox textBox_selectedFile;
        private System.Windows.Forms.Button button_selectFile;
        private System.Windows.Forms.ComboBox comPara_source;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox comPara_selector;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TextBox comPara_posx;
        private System.Windows.Forms.TextBox comPara_posy;
        private System.Windows.Forms.TextBox comPara_posz;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TextBox comPara_vol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TextBox comPara_volmin;
        private System.Windows.Forms.TrackBar comPara_volmin_bar;
        private System.Windows.Forms.TrackBar comPara_vol_bar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Button coms_plus;
        private System.Windows.Forms.Button coms_minus;
    }
}

