using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenePainter
{
    public partial class Form1 : Form
    {
        Bitmap targetBitmap;

        public Form1()
        {
            InitializeComponent();
        }

        public void openFile()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF,*.PNG|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    targetBitmap = (Bitmap)Image.FromFile(openFileDialog1.FileName, true);

                    pictureBoxTargetPreview.Image = targetBitmap;

                    textBoxTargetPath.Text = openFileDialog1.FileName;

                    textBoxDims.Text = Convert.ToString(targetBitmap.Height) + " x " + Convert.ToString(targetBitmap.Width) + ", " + Convert.ToString(targetBitmap.Height * targetBitmap.Width) + " pixels";

                }
                catch (System.IO.FileNotFoundException)
                {
                    MessageBox.Show("There was an error opening the bitmap." +
                        "Please check the path.");
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }


        #region Trackbar to Textbox updaters

        private void trackBarPopSize_Scroll(object sender, EventArgs e)
        {
            textBoxPopSize.Text = Convert.ToString(trackBarPopSize.Value);
        }

        private void trackBarChampRate_Scroll(object sender, EventArgs e)
        {
            textBoxChampRate.Text = Convert.ToString(trackBarChampRate.Value);
        }

        private void trackBarMuteRate_Scroll(object sender, EventArgs e)
        {
            textBoxMuteRate.Text = Convert.ToString(trackBarMuteRate.Value);
        }

        private void trackBarFitnessAcc_Scroll(object sender, EventArgs e)
        {
            textBoxFitnessAcc.Text = Convert.ToString(trackBarFitnessAcc.Value);
        }

        private void trackBarGenComplex_Scroll(object sender, EventArgs e)
        {
            textBoxGenComplex.Text = Convert.ToString(trackBarGenComplex.Value);
        }

        private void trackBarPlatLen_Scroll(object sender, EventArgs e)
        {
            textBoxPlatLen.Text = Convert.ToString(trackBarPlatLen.Value);
        }

        private void trackBarGenerations_Scroll(object sender, EventArgs e)
        {
            textBoxGenerations.Text = Convert.ToString(trackBarGenerations.Value);
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxStyle.SelectedIndex = 0;

            trackBarPopSize.Value = Convert.ToInt32(textBoxPopSize.Text);
            trackBarChampRate.Value = Convert.ToInt32(textBoxChampRate.Text);
            trackBarMuteRate.Value = Convert.ToInt32(textBoxMuteRate.Text);
            trackBarFitnessAcc.Value = Convert.ToInt32(textBoxFitnessAcc.Text);
            trackBarGenComplex.Value = Convert.ToInt32(textBoxGenComplex.Text);
            trackBarPlatLen.Value = Convert.ToInt32(textBoxPlatLen.Text);
            trackBarGenerations.Value = Convert.ToInt32(textBoxGenerations.Text);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBoxTargetPath.Text != "")
            {
                PaintingForm form = new PaintingForm();
                form.target = targetBitmap;

                form.geneticbitmap.populationSize = Convert.ToInt32(textBoxPopSize.Text);
                form.geneticbitmap.maxChampions = Convert.ToInt32(textBoxChampRate.Text);
                form.geneticbitmap.mutationRate = Convert.ToInt32(textBoxMuteRate.Text);
                form.geneticbitmap.accuracy = Convert.ToInt32(textBoxFitnessAcc.Text);
                form.geneticbitmap.genomeLength = Convert.ToInt32(textBoxGenComplex.Text);
                form.geneticbitmap.plateauMax = Convert.ToInt32(textBoxPlatLen.Text);
                form.geneticbitmap.maxGenerations = Convert.ToInt32(textBoxGenerations.Text);

                form.geneticbitmap.genomeDynamic = checkBoxDynGen.Checked;
                form.geneticbitmap.keepBest = checkBoxKeepBest.Checked;
                form.geneticbitmap.restoreDinosaurs = checkBoxDinosaur.Checked;
                form.geneticbitmap.ruinPlateaus = checkBoxPlat.Checked;
                form.geneticbitmap.useLog = checkBoxLog.Checked;
                form.geneticbitmap.infinite = checkBoxInfinity.Checked;







                form.Show();

                
            }
        }

        

        
    }
}
