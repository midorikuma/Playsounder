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
            label0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)PitchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VolumeBar).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            listBox2.Size = new System.Drawing.Size(109, 334);
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
            listBox3.Size = new System.Drawing.Size(109, 334);
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
            listBox4.Size = new System.Drawing.Size(109, 334);
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
            listBox5.Size = new System.Drawing.Size(109, 334);
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
            Pitch0Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            Pitch0Button.Location = new System.Drawing.Point(4, 2);
            Pitch0Button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Pitch0Button.Name = "Pitch0Button";
            Pitch0Button.Size = new System.Drawing.Size(31, 22);
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
            PitchBar.Size = new System.Drawing.Size(210, 30);
            PitchBar.TabIndex = 13;
            PitchBar.TickFrequency = 10;
            PitchBar.Scroll += PitchBar_Scroll;
            PitchBar.MouseUp += PlayButton_Click;
            // 
            // Pitch1Button
            // 
            Pitch1Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            Pitch1Button.Location = new System.Drawing.Point(89, 2);
            Pitch1Button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Pitch1Button.Name = "Pitch1Button";
            Pitch1Button.Size = new System.Drawing.Size(31, 22);
            Pitch1Button.TabIndex = 14;
            Pitch1Button.Text = "1.0";
            Pitch1Button.UseVisualStyleBackColor = true;
            Pitch1Button.Click += PitchButton_Click;
            // 
            // Pitch2Button
            // 
            Pitch2Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            Pitch2Button.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Pitch2Button.Location = new System.Drawing.Point(175, 2);
            Pitch2Button.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Pitch2Button.Name = "Pitch2Button";
            Pitch2Button.Size = new System.Drawing.Size(31, 22);
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
            PitchText.Size = new System.Drawing.Size(50, 23);
            PitchText.TabIndex = 16;
            PitchText.Text = "1.0";
            PitchText.TextChanged += PitchText_TextChanged;
            // 
            // StopButton
            // 
            StopButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            StopButton.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StopButton.Location = new System.Drawing.Point(240, 1);
            StopButton.Margin = new System.Windows.Forms.Padding(1);
            StopButton.Name = "StopButton";
            StopButton.Size = new System.Drawing.Size(27, 24);
            StopButton.TabIndex = 18;
            StopButton.Text = "■";
            StopButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // VolumeBar
            // 
            VolumeBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            VolumeBar.Location = new System.Drawing.Point(297, 5);
            VolumeBar.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            VolumeBar.Maximum = 100;
            VolumeBar.Minimum = -100;
            VolumeBar.Name = "VolumeBar";
            VolumeBar.Size = new System.Drawing.Size(72, 21);
            VolumeBar.TabIndex = 19;
            VolumeBar.TickFrequency = 0;
            VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            VolumeBar.Scroll += VolumeBar_Scroll;
            // 
            // CommandText
            // 
            CommandText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            CommandText.Location = new System.Drawing.Point(368, 4);
            CommandText.Margin = new System.Windows.Forms.Padding(4);
            CommandText.Name = "CommandText";
            CommandText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            CommandText.Size = new System.Drawing.Size(371, 23);
            CommandText.TabIndex = 20;
            // 
            // CopyButton
            // 
            CopyButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            CopyButton.Location = new System.Drawing.Point(694, 2);
            CopyButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            CopyButton.Name = "CopyButton";
            CopyButton.Size = new System.Drawing.Size(45, 22);
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
            MuteButton.Location = new System.Drawing.Point(269, 1);
            MuteButton.Margin = new System.Windows.Forms.Padding(1);
            MuteButton.Name = "MuteButton";
            MuteButton.Size = new System.Drawing.Size(27, 24);
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
            tableLayoutPanel1.Size = new System.Drawing.Size(743, 388);
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
            listBox1.Size = new System.Drawing.Size(109, 334);
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
            listBox6.Size = new System.Drawing.Size(109, 334);
            listBox6.TabIndex = 11;
            listBox6.Visible = false;
            listBox6.VisibleChanged += AdjustColumnWidthBasedOnListBoxContent;
            listBox6.MouseUp += listBox_SelectedIndexChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
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
            tableLayoutPanel3.Location = new System.Drawing.Point(4, 400);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new System.Drawing.Size(743, 34);
            tableLayoutPanel3.TabIndex = 12;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.Items.AddRange(new object[] { "Command", "Path" });
            comboBox2.Location = new System.Drawing.Point(272, 4);
            comboBox2.Margin = new System.Windows.Forms.Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(88, 23);
            comboBox2.TabIndex = 21;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // PlayButton
            // 
            PlayButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PlayButton.Font = new System.Drawing.Font("MS UI Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PlayButton.Location = new System.Drawing.Point(214, 1);
            PlayButton.Margin = new System.Windows.Forms.Padding(4, 1, 1, 1);
            PlayButton.Name = "PlayButton";
            PlayButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            PlayButton.Size = new System.Drawing.Size(24, 24);
            PlayButton.TabIndex = 17;
            PlayButton.Text = "▶";
            PlayButton.UseVisualStyleBackColor = true;
            PlayButton.Click += PlayButton_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            tableLayoutPanel4.ColumnCount = 8;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 374F));
            tableLayoutPanel4.Controls.Add(Pitch1Button, 1, 0);
            tableLayoutPanel4.Controls.Add(Pitch2Button, 2, 0);
            tableLayoutPanel4.Controls.Add(StopButton, 4, 0);
            tableLayoutPanel4.Controls.Add(PlayButton, 3, 0);
            tableLayoutPanel4.Controls.Add(CopyButton, 7, 0);
            tableLayoutPanel4.Controls.Add(VolumeBar, 6, 0);
            tableLayoutPanel4.Controls.Add(MuteButton, 5, 0);
            tableLayoutPanel4.Controls.Add(Pitch0Button, 0, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(4, 431);
            tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new System.Drawing.Size(743, 26);
            tableLayoutPanel4.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 849F));
            tableLayoutPanel2.Controls.Add(label0, 0, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(4, 398);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            tableLayoutPanel2.Size = new System.Drawing.Size(743, 10);
            tableLayoutPanel2.TabIndex = 24;
            // 
            // label0
            // 
            label0.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label0.Location = new System.Drawing.Point(4, 0);
            label0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label0.Name = "label0";
            label0.Size = new System.Drawing.Size(841, 1);
            label0.TabIndex = 11;
            label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(751, 460);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(comboBox1);
            Controls.Add(tableLayoutPanel3);
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
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label6;
    }
}

