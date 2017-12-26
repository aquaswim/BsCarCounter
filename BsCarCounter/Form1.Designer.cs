namespace BsCarCounter
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tibResult = new System.Windows.Forms.TabControl();
            this.tabResult = new System.Windows.Forms.TabPage();
            this.ibResult = new Emgu.CV.UI.ImageBox();
            this.tabBs = new System.Windows.Forms.TabPage();
            this.ibBs = new Emgu.CV.UI.ImageBox();
            this.tibBS = new Emgu.CV.UI.ImageBox();
            this.tibOriginal = new System.Windows.Forms.TabPage();
            this.ibOriginal = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbErodeIter = new System.Windows.Forms.TrackBar();
            this.tbDilateIter = new System.Windows.Forms.TrackBar();
            this.cbDilEroOrder = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbUpdateInterval = new System.Windows.Forms.TrackBar();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.tbVideoSeek = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbGaussianBlur = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFIle = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.ofdVideo = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tbThreshold = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbxCounting = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCountingLanePosX = new System.Windows.Forms.TrackBar();
            this.tbCountingLanePosY = new System.Windows.Forms.TrackBar();
            this.tbCountingLaneSizeWidth = new System.Windows.Forms.TrackBar();
            this.tbCountingLaneSizeHeight = new System.Windows.Forms.TrackBar();
            this.cbxIncoming = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMinSize = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblCarCount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tibResult.SuspendLayout();
            this.tabResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibResult)).BeginInit();
            this.tabBs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibBs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tibBS)).BeginInit();
            this.tibOriginal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbErodeIter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDilateIter)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUpdateInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVideoSeek)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGaussianBlur)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountingLanePosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountingLanePosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountingLaneSizeWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountingLaneSizeHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinSize)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tibResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(834, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tibResult
            // 
            this.tibResult.Controls.Add(this.tabResult);
            this.tibResult.Controls.Add(this.tabBs);
            this.tibResult.Controls.Add(this.tibOriginal);
            this.tibResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tibResult.Location = new System.Drawing.Point(3, 3);
            this.tibResult.Name = "tibResult";
            this.tibResult.SelectedIndex = 0;
            this.tibResult.Size = new System.Drawing.Size(828, 323);
            this.tibResult.TabIndex = 0;
            // 
            // tabResult
            // 
            this.tabResult.Controls.Add(this.ibResult);
            this.tabResult.Location = new System.Drawing.Point(4, 22);
            this.tabResult.Name = "tabResult";
            this.tabResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabResult.Size = new System.Drawing.Size(820, 297);
            this.tabResult.TabIndex = 0;
            this.tabResult.Text = "Result";
            this.tabResult.UseVisualStyleBackColor = true;
            // 
            // ibResult
            // 
            this.ibResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibResult.Location = new System.Drawing.Point(3, 3);
            this.ibResult.Name = "ibResult";
            this.ibResult.Size = new System.Drawing.Size(814, 291);
            this.ibResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ibResult.TabIndex = 2;
            this.ibResult.TabStop = false;
            // 
            // tabBs
            // 
            this.tabBs.Controls.Add(this.ibBs);
            this.tabBs.Controls.Add(this.tibBS);
            this.tabBs.Location = new System.Drawing.Point(4, 22);
            this.tabBs.Name = "tabBs";
            this.tabBs.Size = new System.Drawing.Size(770, 297);
            this.tabBs.TabIndex = 2;
            this.tabBs.Text = "BS";
            this.tabBs.UseVisualStyleBackColor = true;
            // 
            // ibBs
            // 
            this.ibBs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibBs.Location = new System.Drawing.Point(0, 0);
            this.ibBs.Name = "ibBs";
            this.ibBs.Size = new System.Drawing.Size(770, 297);
            this.ibBs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ibBs.TabIndex = 3;
            this.ibBs.TabStop = false;
            // 
            // tibBS
            // 
            this.tibBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tibBS.Location = new System.Drawing.Point(0, 0);
            this.tibBS.Name = "tibBS";
            this.tibBS.Size = new System.Drawing.Size(770, 297);
            this.tibBS.TabIndex = 2;
            this.tibBS.TabStop = false;
            // 
            // tibOriginal
            // 
            this.tibOriginal.Controls.Add(this.ibOriginal);
            this.tibOriginal.Location = new System.Drawing.Point(4, 22);
            this.tibOriginal.Name = "tibOriginal";
            this.tibOriginal.Padding = new System.Windows.Forms.Padding(3);
            this.tibOriginal.Size = new System.Drawing.Size(770, 297);
            this.tibOriginal.TabIndex = 1;
            this.tibOriginal.Text = "Original";
            this.tibOriginal.UseVisualStyleBackColor = true;
            // 
            // ibOriginal
            // 
            this.ibOriginal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ibOriginal.Location = new System.Drawing.Point(3, 3);
            this.ibOriginal.Name = "ibOriginal";
            this.ibOriginal.Size = new System.Drawing.Size(764, 291);
            this.ibOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ibOriginal.TabIndex = 2;
            this.ibOriginal.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 332);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 226);
            this.panel1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.flowLayoutPanel1);
            this.groupBox3.Location = new System.Drawing.Point(212, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(607, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BS Control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Erosion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dilation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // tbErodeIter
            // 
            this.tbErodeIter.Location = new System.Drawing.Point(454, 3);
            this.tbErodeIter.Maximum = 5;
            this.tbErodeIter.Name = "tbErodeIter";
            this.tbErodeIter.Size = new System.Drawing.Size(80, 45);
            this.tbErodeIter.TabIndex = 2;
            this.tbErodeIter.Value = 1;
            // 
            // tbDilateIter
            // 
            this.tbDilateIter.Location = new System.Drawing.Point(320, 3);
            this.tbDilateIter.Maximum = 5;
            this.tbDilateIter.Name = "tbDilateIter";
            this.tbDilateIter.Size = new System.Drawing.Size(80, 45);
            this.tbDilateIter.TabIndex = 1;
            this.tbDilateIter.Value = 1;
            // 
            // cbDilEroOrder
            // 
            this.cbDilEroOrder.Items.AddRange(new object[] {
            "Dilate First",
            "Erosion First",
            "None"});
            this.cbDilEroOrder.Location = new System.Drawing.Point(186, 3);
            this.cbDilEroOrder.Name = "cbDilEroOrder";
            this.cbDilEroOrder.Size = new System.Drawing.Size(80, 21);
            this.cbDilEroOrder.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblSpeed);
            this.groupBox2.Controls.Add(this.tbUpdateInterval);
            this.groupBox2.Controls.Add(this.btnPlayPause);
            this.groupBox2.Controls.Add(this.tbVideoSeek);
            this.groupBox2.Location = new System.Drawing.Point(212, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 76);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Control";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(96, 49);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(77, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "UpdateInterval";
            // 
            // tbUpdateInterval
            // 
            this.tbUpdateInterval.Enabled = false;
            this.tbUpdateInterval.Location = new System.Drawing.Point(165, 41);
            this.tbUpdateInterval.Maximum = 250;
            this.tbUpdateInterval.Minimum = 1;
            this.tbUpdateInterval.Name = "tbUpdateInterval";
            this.tbUpdateInterval.Size = new System.Drawing.Size(104, 45);
            this.tbUpdateInterval.TabIndex = 2;
            this.tbUpdateInterval.Value = 50;
            this.tbUpdateInterval.ValueChanged += new System.EventHandler(this.tbUpdateInterval_ValueChanged);
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Enabled = false;
            this.btnPlayPause.Location = new System.Drawing.Point(15, 44);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // tbVideoSeek
            // 
            this.tbVideoSeek.Enabled = false;
            this.tbVideoSeek.Location = new System.Drawing.Point(6, 16);
            this.tbVideoSeek.Name = "tbVideoSeek";
            this.tbVideoSeek.Size = new System.Drawing.Size(486, 45);
            this.tbVideoSeek.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbGaussianBlur);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFIle);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Location = new System.Drawing.Point(9, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Media Control";
            // 
            // tbGaussianBlur
            // 
            this.tbGaussianBlur.Location = new System.Drawing.Point(9, 98);
            this.tbGaussianBlur.Maximum = 25;
            this.tbGaussianBlur.Name = "tbGaussianBlur";
            this.tbGaussianBlur.Size = new System.Drawing.Size(169, 45);
            this.tbGaussianBlur.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gaussian Blur";
            // 
            // lblFIle
            // 
            this.lblFIle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFIle.Location = new System.Drawing.Point(3, 16);
            this.lblFIle.Name = "lblFIle";
            this.lblFIle.Size = new System.Drawing.Size(178, 37);
            this.lblFIle.TabIndex = 1;
            this.lblFIle.Text = "labelfile";
            this.lblFIle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(55, 56);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Open";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // ofdVideo
            // 
            this.ofdVideo.DefaultExt = "Avi";
            this.ofdVideo.FileName = "video";
            this.ofdVideo.Filter = "Video Files (*.avi)|*.avi";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.tbThreshold);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.cbDilEroOrder);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.tbDilateIter);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.tbErodeIter);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(601, 37);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Threshold";
            // 
            // tbThreshold
            // 
            this.tbThreshold.Location = new System.Drawing.Point(63, 3);
            this.tbThreshold.Maximum = 255;
            this.tbThreshold.Name = "tbThreshold";
            this.tbThreshold.Size = new System.Drawing.Size(80, 45);
            this.tbThreshold.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.flowLayoutPanel2);
            this.groupBox4.Location = new System.Drawing.Point(9, 157);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(810, 60);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Counting Lane Control";
            // 
            // cbxCounting
            // 
            this.cbxCounting.AutoSize = true;
            this.cbxCounting.Location = new System.Drawing.Point(3, 7);
            this.cbxCounting.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.cbxCounting.Name = "cbxCounting";
            this.cbxCounting.Size = new System.Drawing.Size(68, 17);
            this.cbxCounting.TabIndex = 0;
            this.cbxCounting.Text = "Counting";
            this.cbxCounting.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.cbxCounting);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.tbCountingLanePosX);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.tbCountingLanePosY);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.tbCountingLaneSizeWidth);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.tbCountingLaneSizeHeight);
            this.flowLayoutPanel2.Controls.Add(this.cbxIncoming);
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.tbMinSize);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(804, 41);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(183, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(289, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Width";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 8);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Height";
            // 
            // tbCountingLanePosX
            // 
            this.tbCountingLanePosX.Location = new System.Drawing.Point(97, 3);
            this.tbCountingLanePosX.Name = "tbCountingLanePosX";
            this.tbCountingLanePosX.Size = new System.Drawing.Size(80, 45);
            this.tbCountingLanePosX.TabIndex = 5;
            this.tbCountingLanePosX.ValueChanged += new System.EventHandler(this.ReCalcTrackBarCountingLane);
            // 
            // tbCountingLanePosY
            // 
            this.tbCountingLanePosY.Location = new System.Drawing.Point(203, 3);
            this.tbCountingLanePosY.Name = "tbCountingLanePosY";
            this.tbCountingLanePosY.Size = new System.Drawing.Size(80, 45);
            this.tbCountingLanePosY.TabIndex = 6;
            this.tbCountingLanePosY.ValueChanged += new System.EventHandler(this.ReCalcTrackBarCountingLane);
            // 
            // tbCountingLaneSizeWidth
            // 
            this.tbCountingLaneSizeWidth.Location = new System.Drawing.Point(330, 3);
            this.tbCountingLaneSizeWidth.Name = "tbCountingLaneSizeWidth";
            this.tbCountingLaneSizeWidth.Size = new System.Drawing.Size(80, 45);
            this.tbCountingLaneSizeWidth.TabIndex = 7;
            // 
            // tbCountingLaneSizeHeight
            // 
            this.tbCountingLaneSizeHeight.Location = new System.Drawing.Point(460, 3);
            this.tbCountingLaneSizeHeight.Name = "tbCountingLaneSizeHeight";
            this.tbCountingLaneSizeHeight.Size = new System.Drawing.Size(80, 45);
            this.tbCountingLaneSizeHeight.TabIndex = 8;
            // 
            // cbxIncoming
            // 
            this.cbxIncoming.AutoSize = true;
            this.cbxIncoming.Location = new System.Drawing.Point(546, 7);
            this.cbxIncoming.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.cbxIncoming.Name = "cbxIncoming";
            this.cbxIncoming.Size = new System.Drawing.Size(102, 17);
            this.cbxIncoming.TabIndex = 9;
            this.cbxIncoming.Text = "Incoming Traffic";
            this.cbxIncoming.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(654, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "MinSize";
            // 
            // tbMinSize
            // 
            this.tbMinSize.Location = new System.Drawing.Point(704, 3);
            this.tbMinSize.Maximum = 250;
            this.tbMinSize.Name = "tbMinSize";
            this.tbMinSize.Size = new System.Drawing.Size(80, 45);
            this.tbMinSize.TabIndex = 11;
            this.tbMinSize.Value = 100;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lblCarCount);
            this.groupBox5.Location = new System.Drawing.Point(724, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(91, 75);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Car Count";
            // 
            // lblCarCount
            // 
            this.lblCarCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblCarCount.Location = new System.Drawing.Point(3, 16);
            this.lblCarCount.Name = "lblCarCount";
            this.lblCarCount.Size = new System.Drawing.Size(85, 56);
            this.lblCarCount.TabIndex = 0;
            this.lblCarCount.Text = "0";
            this.lblCarCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(850, 600);
            this.Name = "mainForm";
            this.Text = "Car Counter";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tibResult.ResumeLayout(false);
            this.tabResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibResult)).EndInit();
            this.tabBs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibBs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tibBS)).EndInit();
            this.tibOriginal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibOriginal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbErodeIter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDilateIter)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbUpdateInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbVideoSeek)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbGaussianBlur)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbThreshold)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountingLanePosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountingLanePosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountingLaneSizeWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCountingLaneSizeHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMinSize)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tibResult;
        private System.Windows.Forms.TabPage tabResult;
        private System.Windows.Forms.TabPage tabBs;
        private System.Windows.Forms.TabPage tibOriginal;
        private System.Windows.Forms.Panel panel1;
        private Emgu.CV.UI.ImageBox ibResult;
        private Emgu.CV.UI.ImageBox tibBS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFIle;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.OpenFileDialog ofdVideo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar tbVideoSeek;
        private System.Windows.Forms.Button btnPlayPause;
        private Emgu.CV.UI.ImageBox ibOriginal;
        private Emgu.CV.UI.ImageBox ibBs;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.TrackBar tbUpdateInterval;
        private System.Windows.Forms.TrackBar tbGaussianBlur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar tbDilateIter;
        private System.Windows.Forms.ComboBox cbDilEroOrder;
        private System.Windows.Forms.TrackBar tbErodeIter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbThreshold;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox cbxCounting;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar tbCountingLanePosX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar tbCountingLanePosY;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tbCountingLaneSizeWidth;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar tbCountingLaneSizeHeight;
        private System.Windows.Forms.CheckBox cbxIncoming;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar tbMinSize;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblCarCount;
    }
}

