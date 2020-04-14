namespace NetTool
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.GAVG = new System.Windows.Forms.Label();
            this.GMAX = new System.Windows.Forms.Label();
            this.GMIN = new System.Windows.Forms.Label();
            this.WMIN = new System.Windows.Forms.Label();
            this.WMAX = new System.Windows.Forms.Label();
            this.WAVG = new System.Windows.Forms.Label();
            this.RMIN = new System.Windows.Forms.Label();
            this.RMAX = new System.Windows.Forms.Label();
            this.RAVG = new System.Windows.Forms.Label();
            this.GPL = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.WPL = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.RPL = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.packetsToSend = new System.Windows.Forms.NumericUpDown();
            this.gateway = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSingleNAT = new System.Windows.Forms.Label();
            this.lblMAC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numDelay = new System.Windows.Forms.NumericUpDown();
            this.numTimeout = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.downloadspeedlabel = new System.Windows.Forms.Label();
            this.uploadspeedlabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.gbWeave = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblWeaveIP = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbClose = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.packetsToSend)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).BeginInit();
            this.gbWeave.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(672, 31);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(68, 22);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(511, 92);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(223, 225);
            this.listBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Average";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(58, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Min";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(55, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Max";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(35, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Average";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(60, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(57, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Max";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(37, 117);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Average";
            // 
            // GAVG
            // 
            this.GAVG.AutoSize = true;
            this.GAVG.Location = new System.Drawing.Point(84, 29);
            this.GAVG.Name = "GAVG";
            this.GAVG.Size = new System.Drawing.Size(27, 13);
            this.GAVG.TabIndex = 18;
            this.GAVG.Text = "N/A";
            // 
            // GMAX
            // 
            this.GMAX.AutoSize = true;
            this.GMAX.Location = new System.Drawing.Point(84, 52);
            this.GMAX.Name = "GMAX";
            this.GMAX.Size = new System.Drawing.Size(27, 13);
            this.GMAX.TabIndex = 19;
            this.GMAX.Text = "N/A";
            // 
            // GMIN
            // 
            this.GMIN.AutoSize = true;
            this.GMIN.Location = new System.Drawing.Point(84, 77);
            this.GMIN.Name = "GMIN";
            this.GMIN.Size = new System.Drawing.Size(27, 13);
            this.GMIN.TabIndex = 20;
            this.GMIN.Text = "N/A";
            // 
            // WMIN
            // 
            this.WMIN.AutoSize = true;
            this.WMIN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WMIN.Location = new System.Drawing.Point(88, 77);
            this.WMIN.Name = "WMIN";
            this.WMIN.Size = new System.Drawing.Size(27, 13);
            this.WMIN.TabIndex = 23;
            this.WMIN.Text = "N/A";
            // 
            // WMAX
            // 
            this.WMAX.AutoSize = true;
            this.WMAX.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WMAX.Location = new System.Drawing.Point(88, 52);
            this.WMAX.Name = "WMAX";
            this.WMAX.Size = new System.Drawing.Size(27, 13);
            this.WMAX.TabIndex = 22;
            this.WMAX.Text = "N/A";
            // 
            // WAVG
            // 
            this.WAVG.AutoSize = true;
            this.WAVG.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WAVG.Location = new System.Drawing.Point(88, 29);
            this.WAVG.Name = "WAVG";
            this.WAVG.Size = new System.Drawing.Size(27, 13);
            this.WAVG.TabIndex = 21;
            this.WAVG.Text = "N/A";
            // 
            // RMIN
            // 
            this.RMIN.AutoSize = true;
            this.RMIN.Location = new System.Drawing.Point(90, 165);
            this.RMIN.Name = "RMIN";
            this.RMIN.Size = new System.Drawing.Size(27, 13);
            this.RMIN.TabIndex = 26;
            this.RMIN.Text = "N/A";
            // 
            // RMAX
            // 
            this.RMAX.AutoSize = true;
            this.RMAX.Location = new System.Drawing.Point(90, 140);
            this.RMAX.Name = "RMAX";
            this.RMAX.Size = new System.Drawing.Size(27, 13);
            this.RMAX.TabIndex = 25;
            this.RMAX.Text = "N/A";
            // 
            // RAVG
            // 
            this.RAVG.AutoSize = true;
            this.RAVG.Location = new System.Drawing.Point(90, 117);
            this.RAVG.Name = "RAVG";
            this.RAVG.Size = new System.Drawing.Size(27, 13);
            this.RAVG.TabIndex = 24;
            this.RAVG.Text = "N/A";
            // 
            // GPL
            // 
            this.GPL.AutoSize = true;
            this.GPL.Location = new System.Drawing.Point(84, 101);
            this.GPL.Name = "GPL";
            this.GPL.Size = new System.Drawing.Size(27, 13);
            this.GPL.TabIndex = 28;
            this.GPL.Text = "N/A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Packet Loss";
            // 
            // WPL
            // 
            this.WPL.AutoSize = true;
            this.WPL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WPL.Location = new System.Drawing.Point(88, 101);
            this.WPL.Name = "WPL";
            this.WPL.Size = new System.Drawing.Size(27, 13);
            this.WPL.TabIndex = 30;
            this.WPL.Text = "N/A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(16, 101);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Packet Loss";
            // 
            // RPL
            // 
            this.RPL.AutoSize = true;
            this.RPL.Location = new System.Drawing.Point(90, 189);
            this.RPL.Name = "RPL";
            this.RPL.Size = new System.Drawing.Size(27, 13);
            this.RPL.TabIndex = 32;
            this.RPL.Text = "N/A";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Packet Loss";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(212, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(454, 20);
            this.progressBar1.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Packets";
            // 
            // packetsToSend
            // 
            this.packetsToSend.Location = new System.Drawing.Point(23, 54);
            this.packetsToSend.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.packetsToSend.Name = "packetsToSend";
            this.packetsToSend.Size = new System.Drawing.Size(55, 20);
            this.packetsToSend.TabIndex = 37;
            this.packetsToSend.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.packetsToSend.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // gateway
            // 
            this.gateway.AutoSize = true;
            this.gateway.Location = new System.Drawing.Point(88, 48);
            this.gateway.Name = "gateway";
            this.gateway.Size = new System.Drawing.Size(40, 13);
            this.gateway.TabIndex = 38;
            this.gateway.Text = "0.0.0.0";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(47, 25);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 39;
            this.label.Text = "Name";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblName.Location = new System.Drawing.Point(88, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 13);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Unknown";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(65, 48);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "IP";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSingleNAT);
            this.groupBox1.Controls.Add(this.lblMAC);
            this.groupBox1.Controls.Add(this.RPL);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.gateway);
            this.groupBox1.Controls.Add(this.RAVG);
            this.groupBox1.Controls.Add(this.RMAX);
            this.groupBox1.Controls.Add(this.RMIN);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(317, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 221);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Default Gateway";
            // 
            // lblSingleNAT
            // 
            this.lblSingleNAT.AutoSize = true;
            this.lblSingleNAT.Location = new System.Drawing.Point(90, 95);
            this.lblSingleNAT.Name = "lblSingleNAT";
            this.lblSingleNAT.Size = new System.Drawing.Size(27, 13);
            this.lblSingleNAT.TabIndex = 56;
            this.lblSingleNAT.Text = "N/A";
            // 
            // lblMAC
            // 
            this.lblMAC.AutoSize = true;
            this.lblMAC.Location = new System.Drawing.Point(88, 71);
            this.lblMAC.Name = "lblMAC";
            this.lblMAC.Size = new System.Drawing.Size(94, 13);
            this.lblMAC.TabIndex = 43;
            this.lblMAC.Text = "00:00:00:00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Single NAT";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(52, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 13);
            this.label19.TabIndex = 42;
            this.label19.Text = "MAC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Delay";
            // 
            // numDelay
            // 
            this.numDelay.Location = new System.Drawing.Point(84, 54);
            this.numDelay.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.numDelay.Name = "numDelay";
            this.numDelay.Size = new System.Drawing.Size(55, 20);
            this.numDelay.TabIndex = 44;
            this.numDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numDelay.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // numTimeout
            // 
            this.numTimeout.Location = new System.Drawing.Point(145, 54);
            this.numTimeout.Maximum = new decimal(new int[] {
            80000,
            0,
            0,
            0});
            this.numTimeout.Name = "numTimeout";
            this.numTimeout.Size = new System.Drawing.Size(55, 20);
            this.numTimeout.TabIndex = 45;
            this.numTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numTimeout.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Timeout";
            // 
            // downloadspeedlabel
            // 
            this.downloadspeedlabel.AutoSize = true;
            this.downloadspeedlabel.Location = new System.Drawing.Point(84, 31);
            this.downloadspeedlabel.Name = "downloadspeedlabel";
            this.downloadspeedlabel.Size = new System.Drawing.Size(13, 13);
            this.downloadspeedlabel.TabIndex = 47;
            this.downloadspeedlabel.Text = "0";
            // 
            // uploadspeedlabel
            // 
            this.uploadspeedlabel.AutoSize = true;
            this.uploadspeedlabel.Location = new System.Drawing.Point(84, 47);
            this.uploadspeedlabel.Name = "uploadspeedlabel";
            this.uploadspeedlabel.Size = new System.Drawing.Size(13, 13);
            this.uploadspeedlabel.TabIndex = 48;
            this.uploadspeedlabel.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(22, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "Download";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(36, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 50;
            this.label21.Text = "Upload";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblProgress.Location = new System.Drawing.Point(585, 54);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProgress.Size = new System.Drawing.Size(0, 13);
            this.lblProgress.TabIndex = 51;
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbWeave
            // 
            this.gbWeave.Controls.Add(this.label16);
            this.gbWeave.Controls.Add(this.label10);
            this.gbWeave.Controls.Add(this.label9);
            this.gbWeave.Controls.Add(this.label8);
            this.gbWeave.Controls.Add(this.WAVG);
            this.gbWeave.Controls.Add(this.WMAX);
            this.gbWeave.Controls.Add(this.WMIN);
            this.gbWeave.Controls.Add(this.WPL);
            this.gbWeave.Location = new System.Drawing.Point(23, 184);
            this.gbWeave.Name = "gbWeave";
            this.gbWeave.Size = new System.Drawing.Size(141, 133);
            this.gbWeave.TabIndex = 52;
            this.gbWeave.TabStop = false;
            this.gbWeave.Text = "Weave";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.GAVG);
            this.groupBox2.Controls.Add(this.GMAX);
            this.groupBox2.Controls.Add(this.GMIN);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.GPL);
            this.groupBox2.Location = new System.Drawing.Point(170, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(141, 133);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Google";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(61, 117);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 31;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "UT Server";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(61, 140);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 32;
            this.radioButton2.Text = "VA Server";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(61, 163);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 33;
            this.radioButton3.Text = "CA Server";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.downloadspeedlabel);
            this.groupBox3.Controls.Add(this.uploadspeedlabel);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Location = new System.Drawing.Point(170, 96);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(141, 82);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Internet Speed";
            // 
            // lblWeaveIP
            // 
            this.lblWeaveIP.AutoSize = true;
            this.lblWeaveIP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWeaveIP.Location = new System.Drawing.Point(59, 92);
            this.lblWeaveIP.Name = "lblWeaveIP";
            this.lblWeaveIP.Size = new System.Drawing.Size(76, 13);
            this.lblWeaveIP.TabIndex = 32;
            this.lblWeaveIP.Text = "208.53.46.250";
            this.lblWeaveIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 24);
            this.menuStrip1.TabIndex = 55;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.toolsToolStripMenuItem.Text = "Notifications";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // cbClose
            // 
            this.cbClose.AutoSize = true;
            this.cbClose.Location = new System.Drawing.Point(212, 57);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(101, 17);
            this.cbClose.TabIndex = 56;
            this.cbClose.Text = "Close After Test";
            this.cbClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(746, 332);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.lblWeaveIP);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbWeave);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numTimeout);
            this.Controls.Add(this.numDelay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.packetsToSend);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weave Net Tool";
            ((System.ComponentModel.ISupportInitialize)(this.packetsToSend)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeout)).EndInit();
            this.gbWeave.ResumeLayout(false);
            this.gbWeave.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label GAVG;
        private System.Windows.Forms.Label GMAX;
        private System.Windows.Forms.Label GMIN;
        private System.Windows.Forms.Label WMIN;
        private System.Windows.Forms.Label WMAX;
        private System.Windows.Forms.Label WAVG;
        private System.Windows.Forms.Label RMIN;
        private System.Windows.Forms.Label RMAX;
        private System.Windows.Forms.Label RAVG;
        private System.Windows.Forms.Label GPL;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label WPL;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label RPL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown packetsToSend;
        private System.Windows.Forms.Label gateway;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMAC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDelay;
        private System.Windows.Forms.NumericUpDown numTimeout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label downloadspeedlabel;
        private System.Windows.Forms.Label uploadspeedlabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.GroupBox gbWeave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSingleNAT;
        private System.Windows.Forms.Label lblWeaveIP;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbClose;
    }
}

