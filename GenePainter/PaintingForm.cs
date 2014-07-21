using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenePainter
{
    public partial class PaintingForm : Form
    {
        public GeneticBitmap geneticbitmap;
        public Bitmap target;

        public PaintingForm()
        {
            InitializeComponent();
            geneticbitmap = new GeneticBitmap();
        }

        private void PaintingForm_Load(object sender, EventArgs e)
        {
            geneticbitmap.Start(target);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBoxCurrent.Image = geneticbitmap.PublicStatus.CurrentBitmap;
            textBoxCurrentFit.Text = Convert.ToString(geneticbitmap.PublicStatus.CurrentFitness);
            textBoxCurrentComplex.Text = Convert.ToString(geneticbitmap.PublicStatus.CurrentComplexity);

            pictureBoxBest.Image = geneticbitmap.PublicStatus.BestBitmap;
            textBoxBestFit.Text = Convert.ToString(geneticbitmap.PublicStatus.BestFitness);
            textBoxBestComplex.Text = Convert.ToString(geneticbitmap.PublicStatus.BestComplexity);

            progressBar.Value = geneticbitmap.GenerationProgress;

            textBoxGeneration.Text = Convert.ToString(geneticbitmap.PublicStatus.Generation);
        }

        private void butonSaveBest_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "Bitmap Files(*.BMP)|*.BMP|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                geneticbitmap.PublicStatus.BestBitmap.Save(saveFileDialog1.FileName);
            }
            
        }

        

    }
}
