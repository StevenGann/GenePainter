namespace GenePainter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.textBoxTargetPath = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDims = new System.Windows.Forms.TextBox();
            this.pictureBoxTargetPreview = new System.Windows.Forms.PictureBox();
            this.textBoxGenerations = new System.Windows.Forms.TextBox();
            this.trackBarGenerations = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxInfinity = new System.Windows.Forms.CheckBox();
            this.checkBoxDynGen = new System.Windows.Forms.CheckBox();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.checkBoxKeepBest = new System.Windows.Forms.CheckBox();
            this.checkBoxPlat = new System.Windows.Forms.CheckBox();
            this.checkBoxDinosaur = new System.Windows.Forms.CheckBox();
            this.textBoxPlatLen = new System.Windows.Forms.TextBox();
            this.trackBarPlatLen = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxGenComplex = new System.Windows.Forms.TextBox();
            this.trackBarGenComplex = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFitnessAcc = new System.Windows.Forms.TextBox();
            this.trackBarFitnessAcc = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMuteRate = new System.Windows.Forms.TextBox();
            this.trackBarMuteRate = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxChampRate = new System.Windows.Forms.TextBox();
            this.trackBarChampRate = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPopSize = new System.Windows.Forms.TextBox();
            this.trackBarPopSize = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTargetPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGenerations)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlatLen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGenComplex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFitnessAcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMuteRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChampRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPopSize)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 549);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(790, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel1.Text = "Status: Need File";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveConfigToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.openToolStripMenuItem.Text = "Open Image";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveToolStripMenuItem.Text = "Open Config";
            // 
            // saveConfigToolStripMenuItem
            // 
            this.saveConfigToolStripMenuItem.Name = "saveConfigToolStripMenuItem";
            this.saveConfigToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.saveConfigToolStripMenuItem.Text = "Save Config";
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 26);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // textBoxTargetPath
            // 
            this.textBoxTargetPath.Location = new System.Drawing.Point(93, 28);
            this.textBoxTargetPath.Name = "textBoxTargetPath";
            this.textBoxTargetPath.Size = new System.Drawing.Size(687, 20);
            this.textBoxTargetPath.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 55);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxDims);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxTargetPreview);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxGenerations);
            this.splitContainer1.Panel2.Controls.Add(this.trackBarGenerations);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPlatLen);
            this.splitContainer1.Panel2.Controls.Add(this.trackBarPlatLen);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.buttonStart);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxGenComplex);
            this.splitContainer1.Panel2.Controls.Add(this.trackBarGenComplex);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxFitnessAcc);
            this.splitContainer1.Panel2.Controls.Add(this.trackBarFitnessAcc);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxMuteRate);
            this.splitContainer1.Panel2.Controls.Add(this.trackBarMuteRate);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxChampRate);
            this.splitContainer1.Panel2.Controls.Add(this.trackBarChampRate);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPopSize);
            this.splitContainer1.Panel2.Controls.Add(this.trackBarPopSize);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxStyle);
            this.splitContainer1.Size = new System.Drawing.Size(792, 493);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 471);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Dimensions:";
            // 
            // textBoxDims
            // 
            this.textBoxDims.Location = new System.Drawing.Point(82, 468);
            this.textBoxDims.Name = "textBoxDims";
            this.textBoxDims.Size = new System.Drawing.Size(310, 20);
            this.textBoxDims.TabIndex = 1;
            // 
            // pictureBoxTargetPreview
            // 
            this.pictureBoxTargetPreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxTargetPreview.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTargetPreview.Image")));
            this.pictureBoxTargetPreview.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxTargetPreview.InitialImage")));
            this.pictureBoxTargetPreview.Location = new System.Drawing.Point(13, 4);
            this.pictureBoxTargetPreview.Name = "pictureBoxTargetPreview";
            this.pictureBoxTargetPreview.Size = new System.Drawing.Size(380, 458);
            this.pictureBoxTargetPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTargetPreview.TabIndex = 0;
            this.pictureBoxTargetPreview.TabStop = false;
            // 
            // textBoxGenerations
            // 
            this.textBoxGenerations.Location = new System.Drawing.Point(314, 320);
            this.textBoxGenerations.Name = "textBoxGenerations";
            this.textBoxGenerations.Size = new System.Drawing.Size(65, 20);
            this.textBoxGenerations.TabIndex = 29;
            this.textBoxGenerations.Text = "1000";
            // 
            // trackBarGenerations
            // 
            this.trackBarGenerations.Location = new System.Drawing.Point(91, 320);
            this.trackBarGenerations.Maximum = 100000;
            this.trackBarGenerations.Name = "trackBarGenerations";
            this.trackBarGenerations.Size = new System.Drawing.Size(217, 42);
            this.trackBarGenerations.TabIndex = 28;
            this.trackBarGenerations.TickFrequency = 1000;
            this.trackBarGenerations.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarGenerations.Scroll += new System.EventHandler(this.trackBarGenerations_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Generations::";
            this.toolTip1.SetToolTip(this.label9, "How many generations to run for.");
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.checkBoxInfinity);
            this.panel1.Controls.Add(this.checkBoxDynGen);
            this.panel1.Controls.Add(this.checkBoxLog);
            this.panel1.Controls.Add(this.checkBoxKeepBest);
            this.panel1.Controls.Add(this.checkBoxPlat);
            this.panel1.Controls.Add(this.checkBoxDinosaur);
            this.panel1.Location = new System.Drawing.Point(6, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 71);
            this.panel1.TabIndex = 26;
            // 
            // checkBoxInfinity
            // 
            this.checkBoxInfinity.AutoSize = true;
            this.checkBoxInfinity.Location = new System.Drawing.Point(142, 49);
            this.checkBoxInfinity.Name = "checkBoxInfinity";
            this.checkBoxInfinity.Size = new System.Drawing.Size(85, 17);
            this.checkBoxInfinity.TabIndex = 26;
            this.checkBoxInfinity.Text = "Run Forever";
            this.toolTip1.SetToolTip(this.checkBoxInfinity, "Keep running until something kills it.");
            this.checkBoxInfinity.UseVisualStyleBackColor = true;
            // 
            // checkBoxDynGen
            // 
            this.checkBoxDynGen.AutoSize = true;
            this.checkBoxDynGen.Checked = true;
            this.checkBoxDynGen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpProvider1.SetHelpString(this.checkBoxDynGen, "Allows the genome to increase and decrease in size. Allows for variable complexit" +
        "y.");
            this.checkBoxDynGen.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDynGen.Name = "checkBoxDynGen";
            this.helpProvider1.SetShowHelp(this.checkBoxDynGen, true);
            this.checkBoxDynGen.Size = new System.Drawing.Size(133, 17);
            this.checkBoxDynGen.TabIndex = 14;
            this.checkBoxDynGen.Text = "Dynamic Genome Size";
            this.toolTip1.SetToolTip(this.checkBoxDynGen, "Allows the genome to increase and decrease in size. Allows for variable complexit" +
        "y.");
            this.checkBoxDynGen.UseVisualStyleBackColor = true;
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Checked = true;
            this.checkBoxLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLog.Location = new System.Drawing.Point(142, 26);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(110, 17);
            this.checkBoxLog.TabIndex = 25;
            this.checkBoxLog.Text = "Generate Log File";
            this.toolTip1.SetToolTip(this.checkBoxLog, "Output status info to a text file.");
            this.checkBoxLog.UseVisualStyleBackColor = true;
            // 
            // checkBoxKeepBest
            // 
            this.checkBoxKeepBest.AutoSize = true;
            this.checkBoxKeepBest.Checked = true;
            this.checkBoxKeepBest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKeepBest.Location = new System.Drawing.Point(3, 26);
            this.checkBoxKeepBest.Name = "checkBoxKeepBest";
            this.checkBoxKeepBest.Size = new System.Drawing.Size(75, 17);
            this.checkBoxKeepBest.TabIndex = 19;
            this.checkBoxKeepBest.Text = "Keep Best";
            this.toolTip1.SetToolTip(this.checkBoxKeepBest, "Always keep the best genomes untouched.");
            this.checkBoxKeepBest.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlat
            // 
            this.checkBoxPlat.AutoSize = true;
            this.checkBoxPlat.Location = new System.Drawing.Point(142, 3);
            this.checkBoxPlat.Name = "checkBoxPlat";
            this.checkBoxPlat.Size = new System.Drawing.Size(92, 17);
            this.checkBoxPlat.TabIndex = 24;
            this.checkBoxPlat.Text = "Ruin Plateaus";
            this.toolTip1.SetToolTip(this.checkBoxPlat, "When a plateau is detected, trigger mass mutation.");
            this.checkBoxPlat.UseVisualStyleBackColor = true;
            // 
            // checkBoxDinosaur
            // 
            this.checkBoxDinosaur.AutoSize = true;
            this.checkBoxDinosaur.Location = new System.Drawing.Point(3, 49);
            this.checkBoxDinosaur.Name = "checkBoxDinosaur";
            this.checkBoxDinosaur.Size = new System.Drawing.Size(113, 17);
            this.checkBoxDinosaur.TabIndex = 20;
            this.checkBoxDinosaur.Text = "Restore Dinosaurs";
            this.toolTip1.SetToolTip(this.checkBoxDinosaur, "Periodically bring back extinct genomes.");
            this.checkBoxDinosaur.UseVisualStyleBackColor = true;
            // 
            // textBoxPlatLen
            // 
            this.textBoxPlatLen.Location = new System.Drawing.Point(314, 272);
            this.textBoxPlatLen.Name = "textBoxPlatLen";
            this.textBoxPlatLen.Size = new System.Drawing.Size(65, 20);
            this.textBoxPlatLen.TabIndex = 23;
            this.textBoxPlatLen.Text = "100";
            // 
            // trackBarPlatLen
            // 
            this.trackBarPlatLen.Location = new System.Drawing.Point(91, 272);
            this.trackBarPlatLen.Maximum = 500;
            this.trackBarPlatLen.Name = "trackBarPlatLen";
            this.trackBarPlatLen.Size = new System.Drawing.Size(217, 42);
            this.trackBarPlatLen.TabIndex = 22;
            this.trackBarPlatLen.TickFrequency = 10;
            this.trackBarPlatLen.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPlatLen.Scroll += new System.EventHandler(this.trackBarPlatLen_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Plateau Length:";
            this.toolTip1.SetToolTip(this.label7, "How long to go without improvement before it\'s considered a plateau.");
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(6, 442);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(383, 47);
            this.buttonStart.TabIndex = 18;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxGenComplex
            // 
            this.textBoxGenComplex.Location = new System.Drawing.Point(314, 224);
            this.textBoxGenComplex.Name = "textBoxGenComplex";
            this.textBoxGenComplex.Size = new System.Drawing.Size(65, 20);
            this.textBoxGenComplex.TabIndex = 17;
            this.textBoxGenComplex.Text = "3200";
            // 
            // trackBarGenComplex
            // 
            this.trackBarGenComplex.Location = new System.Drawing.Point(112, 224);
            this.trackBarGenComplex.Maximum = 8000;
            this.trackBarGenComplex.Name = "trackBarGenComplex";
            this.trackBarGenComplex.Size = new System.Drawing.Size(196, 42);
            this.trackBarGenComplex.TabIndex = 16;
            this.trackBarGenComplex.TickFrequency = 100;
            this.trackBarGenComplex.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarGenComplex.Scroll += new System.EventHandler(this.trackBarGenComplex_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Genome Complexity:";
            this.toolTip1.SetToolTip(this.label6, "How many genes in a single genome.");
            // 
            // textBoxFitnessAcc
            // 
            this.textBoxFitnessAcc.Location = new System.Drawing.Point(314, 176);
            this.textBoxFitnessAcc.Name = "textBoxFitnessAcc";
            this.textBoxFitnessAcc.Size = new System.Drawing.Size(65, 20);
            this.textBoxFitnessAcc.TabIndex = 13;
            this.textBoxFitnessAcc.Text = "50";
            // 
            // trackBarFitnessAcc
            // 
            this.trackBarFitnessAcc.Location = new System.Drawing.Point(100, 176);
            this.trackBarFitnessAcc.Maximum = 100;
            this.trackBarFitnessAcc.Name = "trackBarFitnessAcc";
            this.trackBarFitnessAcc.Size = new System.Drawing.Size(208, 42);
            this.trackBarFitnessAcc.TabIndex = 12;
            this.trackBarFitnessAcc.TickFrequency = 5;
            this.trackBarFitnessAcc.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarFitnessAcc.Scroll += new System.EventHandler(this.trackBarFitnessAcc_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fitness Accuracy:";
            this.toolTip1.SetToolTip(this.label5, "How closely to compare the genome to the target image.");
            // 
            // textBoxMuteRate
            // 
            this.textBoxMuteRate.Location = new System.Drawing.Point(314, 128);
            this.textBoxMuteRate.Name = "textBoxMuteRate";
            this.textBoxMuteRate.Size = new System.Drawing.Size(65, 20);
            this.textBoxMuteRate.TabIndex = 10;
            this.textBoxMuteRate.Text = "5";
            // 
            // trackBarMuteRate
            // 
            this.trackBarMuteRate.Location = new System.Drawing.Point(86, 128);
            this.trackBarMuteRate.Maximum = 100;
            this.trackBarMuteRate.Name = "trackBarMuteRate";
            this.trackBarMuteRate.Size = new System.Drawing.Size(222, 42);
            this.trackBarMuteRate.TabIndex = 9;
            this.trackBarMuteRate.TickFrequency = 5;
            this.trackBarMuteRate.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarMuteRate.Scroll += new System.EventHandler(this.trackBarMuteRate_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mutation Rate:";
            this.toolTip1.SetToolTip(this.label4, "Percent chance of a gene getting a random value.");
            // 
            // textBoxChampRate
            // 
            this.textBoxChampRate.Location = new System.Drawing.Point(314, 80);
            this.textBoxChampRate.Name = "textBoxChampRate";
            this.textBoxChampRate.Size = new System.Drawing.Size(65, 20);
            this.textBoxChampRate.TabIndex = 7;
            this.textBoxChampRate.Text = "5";
            // 
            // trackBarChampRate
            // 
            this.trackBarChampRate.Location = new System.Drawing.Point(92, 80);
            this.trackBarChampRate.Maximum = 50;
            this.trackBarChampRate.Name = "trackBarChampRate";
            this.trackBarChampRate.Size = new System.Drawing.Size(216, 42);
            this.trackBarChampRate.TabIndex = 6;
            this.trackBarChampRate.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarChampRate.Scroll += new System.EventHandler(this.trackBarChampRate_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Champion Rate:";
            this.toolTip1.SetToolTip(this.label3, "What percentage of the population is allowed to advance.");
            // 
            // textBoxPopSize
            // 
            this.textBoxPopSize.Location = new System.Drawing.Point(314, 32);
            this.textBoxPopSize.Name = "textBoxPopSize";
            this.textBoxPopSize.Size = new System.Drawing.Size(65, 20);
            this.textBoxPopSize.TabIndex = 4;
            this.textBoxPopSize.Text = "100";
            // 
            // trackBarPopSize
            // 
            this.trackBarPopSize.Location = new System.Drawing.Point(92, 32);
            this.trackBarPopSize.Maximum = 500;
            this.trackBarPopSize.Name = "trackBarPopSize";
            this.trackBarPopSize.Size = new System.Drawing.Size(216, 42);
            this.trackBarPopSize.TabIndex = 3;
            this.trackBarPopSize.TickFrequency = 10;
            this.trackBarPopSize.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPopSize.Scroll += new System.EventHandler(this.trackBarPopSize_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Population Size:";
            this.toolTip1.SetToolTip(this.label2, "Number of genomes competing at any one time.");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Style:";
            this.toolTip1.SetToolTip(this.label1, "What shapes to use to paint with.");
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.AllowDrop = true;
            this.comboBoxStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Items.AddRange(new object[] {
            "Rectangles",
            "Ellipses",
            "Text"});
            this.comboBoxStyle.Location = new System.Drawing.Point(47, 4);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(333, 21);
            this.comboBoxStyle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 571);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.textBoxTargetPath);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "GenePainter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTargetPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGenerations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPlatLen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGenComplex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarFitnessAcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMuteRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarChampRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPopSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TextBox textBoxTargetPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBoxTargetPreview;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxGenComplex;
        private System.Windows.Forms.TrackBar trackBarGenComplex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxDynGen;
        private System.Windows.Forms.TextBox textBoxFitnessAcc;
        private System.Windows.Forms.TrackBar trackBarFitnessAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMuteRate;
        private System.Windows.Forms.TrackBar trackBarMuteRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxChampRate;
        private System.Windows.Forms.TrackBar trackBarChampRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPopSize;
        private System.Windows.Forms.TrackBar trackBarPopSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.CheckBox checkBoxKeepBest;
        private System.Windows.Forms.CheckBox checkBoxPlat;
        private System.Windows.Forms.CheckBox checkBoxDinosaur;
        private System.Windows.Forms.TextBox textBoxPlatLen;
        private System.Windows.Forms.TrackBar trackBarPlatLen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDims;
        private System.Windows.Forms.TextBox textBoxGenerations;
        private System.Windows.Forms.TrackBar trackBarGenerations;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxInfinity;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem saveConfigToolStripMenuItem;
    }
}

