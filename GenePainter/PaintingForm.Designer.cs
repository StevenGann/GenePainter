namespace GenePainter
{
    partial class PaintingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintingForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.textBoxCurrentComplex = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCurrentFit = new System.Windows.Forms.TextBox();
            this.pictureBoxCurrent = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBestComplex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxBest = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBestFit = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.butonSaveBest = new System.Windows.Forms.Button();
            this.textBoxGeneration = new System.Windows.Forms.TextBox();
            this.textBoxPlat = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBest)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.progressBar);
            this.splitContainer1.Size = new System.Drawing.Size(792, 573);
            this.splitContainer1.SplitterDistance = 432;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer2.Size = new System.Drawing.Size(792, 432);
            this.splitContainer2.SplitterDistance = 396;
            this.splitContainer2.TabIndex = 0;
            // 
            // textBoxCurrentComplex
            // 
            this.textBoxCurrentComplex.Location = new System.Drawing.Point(225, 25);
            this.textBoxCurrentComplex.Name = "textBoxCurrentComplex";
            this.textBoxCurrentComplex.ReadOnly = true;
            this.textBoxCurrentComplex.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentComplex.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Complexity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fitness:";
            // 
            // textBoxCurrentFit
            // 
            this.textBoxCurrentFit.Location = new System.Drawing.Point(53, 25);
            this.textBoxCurrentFit.Name = "textBoxCurrentFit";
            this.textBoxCurrentFit.ReadOnly = true;
            this.textBoxCurrentFit.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurrentFit.TabIndex = 2;
            // 
            // pictureBoxCurrent
            // 
            this.pictureBoxCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCurrent.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCurrent.Name = "pictureBoxCurrent";
            this.pictureBoxCurrent.Size = new System.Drawing.Size(392, 376);
            this.pictureBoxCurrent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCurrent.TabIndex = 1;
            this.pictureBoxCurrent.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Genome:";
            // 
            // textBoxBestComplex
            // 
            this.textBoxBestComplex.Location = new System.Drawing.Point(224, 22);
            this.textBoxBestComplex.Name = "textBoxBestComplex";
            this.textBoxBestComplex.ReadOnly = true;
            this.textBoxBestComplex.Size = new System.Drawing.Size(100, 20);
            this.textBoxBestComplex.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Complexity:";
            // 
            // pictureBoxBest
            // 
            this.pictureBoxBest.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxBest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBest.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBest.Name = "pictureBoxBest";
            this.pictureBoxBest.Size = new System.Drawing.Size(388, 376);
            this.pictureBoxBest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBest.TabIndex = 4;
            this.pictureBoxBest.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fitness:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Best So Far:";
            // 
            // textBoxBestFit
            // 
            this.textBoxBestFit.Location = new System.Drawing.Point(52, 22);
            this.textBoxBestFit.Name = "textBoxBestFit";
            this.textBoxBestFit.ReadOnly = true;
            this.textBoxBestFit.Size = new System.Drawing.Size(100, 20);
            this.textBoxBestFit.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Finish Now";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // butonSaveBest
            // 
            this.butonSaveBest.Location = new System.Drawing.Point(3, 3);
            this.butonSaveBest.Name = "butonSaveBest";
            this.butonSaveBest.Size = new System.Drawing.Size(103, 23);
            this.butonSaveBest.TabIndex = 7;
            this.butonSaveBest.Text = "Save Current Best";
            this.butonSaveBest.UseVisualStyleBackColor = true;
            this.butonSaveBest.Click += new System.EventHandler(this.butonSaveBest_Click);
            // 
            // textBoxGeneration
            // 
            this.textBoxGeneration.Location = new System.Drawing.Point(195, 3);
            this.textBoxGeneration.Name = "textBoxGeneration";
            this.textBoxGeneration.ReadOnly = true;
            this.textBoxGeneration.Size = new System.Drawing.Size(100, 20);
            this.textBoxGeneration.TabIndex = 6;
            // 
            // textBoxPlat
            // 
            this.textBoxPlat.Location = new System.Drawing.Point(195, 29);
            this.textBoxPlat.Name = "textBoxPlat";
            this.textBoxPlat.ReadOnly = true;
            this.textBoxPlat.Size = new System.Drawing.Size(100, 20);
            this.textBoxPlat.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Mass Mutation";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Inject Dinosaurs";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Generations Since Improvement:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Generation:";
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 110);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(788, 23);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.butonSaveBest);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(578, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 110);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textBoxGeneration);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxPlat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 110);
            this.panel2.TabIndex = 10;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxCurrentComplex);
            this.splitContainer3.Panel1.Controls.Add(this.textBoxCurrentFit);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.pictureBoxCurrent);
            this.splitContainer3.Size = new System.Drawing.Size(392, 428);
            this.splitContainer3.SplitterDistance = 48;
            this.splitContainer3.TabIndex = 6;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.textBoxBestFit);
            this.splitContainer4.Panel1.Controls.Add(this.textBoxBestComplex);
            this.splitContainer4.Panel1.Controls.Add(this.label2);
            this.splitContainer4.Panel1.Controls.Add(this.label6);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.pictureBoxBest);
            this.splitContainer4.Size = new System.Drawing.Size(388, 428);
            this.splitContainer4.SplitterDistance = 48;
            this.splitContainer4.TabIndex = 7;
            // 
            // PaintingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "PaintingForm";
            this.Text = "Painting";
            this.Load += new System.EventHandler(this.PaintingForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCurrentFit;
        private System.Windows.Forms.PictureBox pictureBoxCurrent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBestFit;
        private System.Windows.Forms.TextBox textBoxCurrentComplex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBestComplex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxBest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxGeneration;
        private System.Windows.Forms.TextBox textBoxPlat;
        private System.Windows.Forms.Button butonSaveBest;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer4;

    }
}