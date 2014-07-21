using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenePainter
{
    public class GenBitStatus
    {
        public Bitmap CurrentBitmap;
        public int CurrentFitness;
        public int CurrentComplexity;

        public Bitmap BestBitmap;
        public int BestFitness;
        public int BestComplexity;

        public int Generation;

        public GenBitStatus()
        {
            CurrentBitmap = new Bitmap(1,1);
            CurrentFitness = -1;
            CurrentComplexity = -1;

            BestBitmap = new Bitmap(1,1);
            BestFitness = -1;
            BestComplexity = -1;

            Generation = -1;
        }
    }
}
