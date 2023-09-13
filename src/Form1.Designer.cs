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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pitch0Button = new System.Windows.Forms.Button();
            this.PitchBar = new System.Windows.Forms.TrackBar();
            this.Pitch1Button = new System.Windows.Forms.Button();
            this.Pitch2Button = new System.Windows.Forms.Button();
            this.PitchText = new System.Windows.Forms.TextBox();
            this.StopButton = new System.Windows.Forms.Button();
            this.VolumeBar = new System.Windows.Forms.TrackBar();
            this.CommandText = new System.Windows.Forms.TextBox();
            this.CopyButton = new System.Windows.Forms.Button();
            this.MuteButton = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.PlayButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PitchBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(84, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.DropDown += new System.EventHandler(this.comboBox1_OnDropDownOpened);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Ver.";
            // 
            // listBox2
            // 
            this.listBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(103, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(94, 280);
            this.listBox2.TabIndex = 3;
            this.listBox2.Visible = false;
            this.listBox2.VisibleChanged += new System.EventHandler(this.AdjustColumnWidthBasedOnListBoxContent);
            this.listBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(103, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 12);
            this.label2.TabIndex = 4;
            // 
            // listBox3
            // 
            this.listBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(203, 38);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(94, 280);
            this.listBox3.TabIndex = 5;
            this.listBox3.Visible = false;
            this.listBox3.VisibleChanged += new System.EventHandler(this.AdjustColumnWidthBasedOnListBoxContent);
            this.listBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 12;
            this.listBox4.Location = new System.Drawing.Point(303, 38);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(94, 280);
            this.listBox4.TabIndex = 6;
            this.listBox4.Visible = false;
            this.listBox4.VisibleChanged += new System.EventHandler(this.AdjustColumnWidthBasedOnListBoxContent);
            this.listBox4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(203, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 12);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(303, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 12);
            this.label4.TabIndex = 8;
            // 
            // listBox5
            // 
            this.listBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 12;
            this.listBox5.Location = new System.Drawing.Point(403, 38);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(94, 280);
            this.listBox5.TabIndex = 9;
            this.listBox5.Visible = false;
            this.listBox5.VisibleChanged += new System.EventHandler(this.AdjustColumnWidthBasedOnListBoxContent);
            this.listBox5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Location = new System.Drawing.Point(403, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 12);
            this.label5.TabIndex = 10;
            // 
            // Pitch0Button
            // 
            this.Pitch0Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Pitch0Button.Location = new System.Drawing.Point(0, 6);
            this.Pitch0Button.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.Pitch0Button.Name = "Pitch0Button";
            this.Pitch0Button.Size = new System.Drawing.Size(27, 18);
            this.Pitch0Button.TabIndex = 12;
            this.Pitch0Button.Text = "0.5";
            this.Pitch0Button.UseVisualStyleBackColor = true;
            this.Pitch0Button.Click += new System.EventHandler(this.PitchButton_Click);
            // 
            // PitchBar
            // 
            this.PitchBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PitchBar.Location = new System.Drawing.Point(0, 3);
            this.PitchBar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.PitchBar.Maximum = 100;
            this.PitchBar.Minimum = -100;
            this.PitchBar.Name = "PitchBar";
            this.PitchBar.Size = new System.Drawing.Size(180, 26);
            this.PitchBar.TabIndex = 13;
            this.PitchBar.TickFrequency = 10;
            this.PitchBar.Scroll += new System.EventHandler(this.PitchBar_Scroll);
            this.PitchBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PlayButton_Click);
            // 
            // Pitch1Button
            // 
            this.Pitch1Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pitch1Button.Location = new System.Drawing.Point(76, 6);
            this.Pitch1Button.Name = "Pitch1Button";
            this.Pitch1Button.Size = new System.Drawing.Size(27, 18);
            this.Pitch1Button.TabIndex = 14;
            this.Pitch1Button.Text = "1.0";
            this.Pitch1Button.UseVisualStyleBackColor = true;
            this.Pitch1Button.Click += new System.EventHandler(this.PitchButton_Click);
            // 
            // Pitch2Button
            // 
            this.Pitch2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Pitch2Button.Location = new System.Drawing.Point(153, 6);
            this.Pitch2Button.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Pitch2Button.Name = "Pitch2Button";
            this.Pitch2Button.Size = new System.Drawing.Size(27, 18);
            this.Pitch2Button.TabIndex = 15;
            this.Pitch2Button.Text = "2.0";
            this.Pitch2Button.UseVisualStyleBackColor = true;
            this.Pitch2Button.Click += new System.EventHandler(this.PitchButton_Click);
            // 
            // PitchText
            // 
            this.PitchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PitchText.Location = new System.Drawing.Point(183, 3);
            this.PitchText.Name = "PitchText";
            this.PitchText.Size = new System.Drawing.Size(43, 19);
            this.PitchText.TabIndex = 16;
            this.PitchText.Text = "1.0";
            this.PitchText.TextChanged += new System.EventHandler(this.PitchText_TextChanged);
            // 
            // StopButton
            // 
            this.StopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StopButton.Font = new System.Drawing.Font("MS UI Gothic", 8F);
            this.StopButton.Location = new System.Drawing.Point(206, 3);
            this.StopButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(23, 23);
            this.StopButton.TabIndex = 18;
            this.StopButton.Text = "■";
            this.StopButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // VolumeBar
            // 
            this.VolumeBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VolumeBar.Location = new System.Drawing.Point(255, 4);
            this.VolumeBar.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.VolumeBar.Maximum = 100;
            this.VolumeBar.Minimum = -100;
            this.VolumeBar.Name = "VolumeBar";
            this.VolumeBar.Size = new System.Drawing.Size(61, 23);
            this.VolumeBar.TabIndex = 19;
            this.VolumeBar.TickFrequency = 0;
            this.VolumeBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.VolumeBar.Scroll += new System.EventHandler(this.VolumeBar_Scroll);
            // 
            // CommandText
            // 
            this.CommandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandText.Location = new System.Drawing.Point(314, 3);
            this.CommandText.Name = "CommandText";
            this.CommandText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CommandText.Size = new System.Drawing.Size(320, 19);
            this.CommandText.TabIndex = 20;
            // 
            // CopyButton
            // 
            this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyButton.Location = new System.Drawing.Point(591, 3);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(43, 21);
            this.CopyButton.TabIndex = 21;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CopyButton_Click);
            // 
            // MuteButton
            // 
            this.MuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MuteButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MuteButton.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MuteButton.Location = new System.Drawing.Point(231, 3);
            this.MuteButton.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(23, 23);
            this.MuteButton.TabIndex = 22;
            this.MuteButton.Text = "🔊";
            this.MuteButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MuteButton.UseVisualStyleBackColor = true;
            this.MuteButton.CheckedChanged += new System.EventHandler(this.CheckStateChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listBox3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox6, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 321);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(94, 280);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            this.listBox1.VisibleChanged += new System.EventHandler(this.AdjustColumnWidthBasedOnListBoxContent);
            this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(540, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "ogg files";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.label6.Visible = false;
            // 
            // listBox6
            // 
            this.listBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 12;
            this.listBox6.Location = new System.Drawing.Point(540, 38);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(94, 280);
            this.listBox6.TabIndex = 11;
            this.listBox6.Visible = false;
            this.listBox6.VisibleChanged += new System.EventHandler(this.AdjustColumnWidthBasedOnListBoxContent);
            this.listBox6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.94092F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.16193F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.11597F));
            this.tableLayoutPanel3.Controls.Add(this.PitchBar, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.PitchText, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBox2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.CommandText, 3, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 327);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(637, 29);
            this.tableLayoutPanel3.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "Command",
            "Path"});
            this.comboBox2.Location = new System.Drawing.Point(232, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 20);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // PlayButton
            // 
            this.PlayButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.PlayButton.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.PlayButton.Location = new System.Drawing.Point(183, 3);
            this.PlayButton.Margin = new System.Windows.Forms.Padding(3, 3, 1, 1);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PlayButton.Size = new System.Drawing.Size(21, 23);
            this.PlayButton.TabIndex = 17;
            this.PlayButton.Text = "▶";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 321F));
            this.tableLayoutPanel4.Controls.Add(this.Pitch0Button, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Pitch1Button, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Pitch2Button, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.StopButton, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.PlayButton, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.CopyButton, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.VolumeBar, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.MuteButton, 5, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 352);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(637, 27);
            this.tableLayoutPanel4.TabIndex = 25;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 728F));
            this.tableLayoutPanel2.Controls.Add(this.label0, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 323);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(637, 6);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // label0
            // 
            this.label0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label0.Location = new System.Drawing.Point(3, 0);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(722, 1);
            this.label0.TabIndex = 11;
            this.label0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 382);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Playsounder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PitchBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

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

