using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;

namespace GenePainter
{
    public class GeneticBitmap
    {
        Random RNG;
        BackgroundWorker worker;
        Bitmap targetBitmap;

        //GA Options
        //=============================
        public int populationSize = 200;
        public int maxChampions = 5;
        public int mutationRate = 5;
        public int accuracy = 75;
        public int genomeLength = 3200;
        public int plateauMax = 100;
        public int maxGenerations = 10000;
        public int style = 0;

        public bool genomeDynamic = true;
        public bool keepBest = true;
        public bool restoreDinosaurs = false;
        public bool ruinPlateaus = false;
        public bool useLog = true;
        public bool infinite = false;
        //=============================

        public int generation = 0;
        public Genome bestGenome;
        public int bestFitness;
        public Bitmap generatedBitmap;
        public Bitmap publicGeneratedBitmap;

        public GenBitStatus Status;
        public GenBitStatus PublicStatus;

        public int GenerationProgress;

        private List<Genome> population;
        private List<Genome> champions;

        private object lockObject;
        

        //Default constructor
        public GeneticBitmap()
        {
            RNG = new Random();
            worker = new BackgroundWorker();
            lockObject = new Object();

            population = new List<Genome>(populationSize);
            champions = new List<Genome>(maxChampions);

            Status = new GenBitStatus();
        }

        public void Start(Bitmap input)
        {
            targetBitmap = new Bitmap(input);
            publicGeneratedBitmap = new Bitmap(targetBitmap.Width, targetBitmap.Height);

            Status = new GenBitStatus();
            PublicStatus = new GenBitStatus();

            // Create a background worker thread that ReportsProgress &
            // SupportsCancellation
            // Hook up the appropriate events.
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            ShowConsoleWindow();
             Console.WriteLine("Console Opened");

            worker.RunWorkerAsync();
        }

        //Threading methods
        //==================================================================================
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            //Insert heavy stuff here.
            GeneticAlgorithm();
            
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // This function fires on the UI thread so it's safe to edit
            // the UI control directly, no funny business with Control.Invoke
            // Update the progressBar with the integer supplied to us from the
            // ReportProgress() function. 

            lock (this)
            {
                publicGeneratedBitmap = new Bitmap(generatedBitmap);
                //publicGeneratedBitmap.Save(Convert.ToString(RNG.Next()) + ".bmp");

                if (Status.CurrentBitmap != null)
                {
                    PublicStatus.CurrentBitmap = new Bitmap(Status.CurrentBitmap);
                }
                PublicStatus.CurrentFitness = Status.CurrentFitness;
                PublicStatus.CurrentComplexity = Status.CurrentComplexity;

                if (Status.BestBitmap != null)
                {
                    PublicStatus.BestBitmap = new Bitmap(Status.BestBitmap);
                }
                PublicStatus.BestFitness = Status.BestFitness;
                PublicStatus.BestComplexity = Status.BestComplexity;

                PublicStatus.Generation = Status.Generation;
            }
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // The background process is complete. We need to inspect
            // our response to see if an error occurred, a cancel was
            // requested or if we completed successfully.  
            if (e.Cancelled)
            { }
            // Check to see if an error occurred in the background process.
            else if (e.Error != null)
            { }
            else
            { }
        }
        //==================================================================================

        private void GeneticAlgorithm()
        {
            //Create initial population. Done.
            Console.WriteLine("Creating Initial Population\n");
            for (int i = 0; i <= populationSize; i++)
            {
                population.Insert(i, new Genome(genomeLength, RNG.Next()));
            }

            for (int i = 0; i <= maxChampions; i++)
            {
                champions.Insert(i, new Genome(genomeLength, RNG.Next()));
            }

            Console.WriteLine("Done. Starting Evolution.\n");
            while(generation <= maxGenerations)
            {
                Status.Generation = generation;

                // 1. Test Fitnesses
                Console.WriteLine("Generation: "+Convert.ToString(generation));
                Console.WriteLine("Testing Fitness");
                for (int i = 0; i <= populationSize; i++)
                {
                    population[i].Fitness = FitnessFunction(population[i]);
                    GenerationProgress = (int)(100 * i / populationSize);
                }

                // 2. Name Champions
                Console.WriteLine("\nNaming Champions");
                for (int i = 0; i <= populationSize; i++)
                {
                    FindChampions(population[i]);
                }

                // 3. Breed New Generation
                Console.WriteLine("Breeding");
                Breed();

                generation++;
            }
        }



        private void Breed()
        {
            int index = 0;

            while (index <= maxChampions)
            {
                population[index] = champions[index];
                index++;
            }

            for (int i = 0; i <= (int)((float)populationSize / 10.0f); i++)
            {
                int a = RNG.Next(maxChampions);
                population[index] = new Genome(champions[a], new Genome(genomeLength, RNG.Next()), RNG.Next());
                index++;
            }

            while (index <= populationSize)
            {
                int a = RNG.Next(maxChampions);
                int b = RNG.Next(maxChampions);

                population[index] = new Genome(champions[a], champions[b], RNG.Next());
                population[index].Mutate(mutationRate);

                index++;
            }
        }

        private void FindChampions(Genome genome)
        {
            if (genome.Fitness > champions[maxChampions].Fitness)
            {
                for (int i = 0; i <= maxChampions; i++)
                {
                    if (genome.Fitness > champions[i].Fitness)
                    {
                        champions[i] = genome;
                        break;
                    }
                }
            }

        }

        private int FitnessFunction(Genome genome)
        {
            float fitness = 0;

            generatedBitmap = GenomeToBitmap(genome);

            int sampleSize = (int)((float)((int)targetBitmap.Width * (int)targetBitmap.Height) * ((float)accuracy/100.0f));

            Bitmap tb;
            Bitmap gb;

            lock (this)
            {
                tb = new Bitmap(targetBitmap);
                gb = new Bitmap(generatedBitmap);
            }

            Thread threadA;
            Thread threadB;
            Thread threadC;
            Thread threadD;
            /*
            Thread threadE;
            Thread threadF;
            Thread threadG;
            Thread threadH;
            */
            threadA = new Thread(() => { fitness += FitnessThreadMethod((int)sampleSize / 4, new Bitmap(tb), new Bitmap(gb), new Random(RNG.Next())); });
            threadA.Start();
            threadA.Join();

            threadB = new Thread(() => { fitness += FitnessThreadMethod((int)sampleSize / 4, new Bitmap(tb), new Bitmap(gb), new Random(RNG.Next())); });
            threadB.Start();
            threadB.Join();

            threadC = new Thread(() => { fitness += FitnessThreadMethod((int)sampleSize / 4, new Bitmap(tb), new Bitmap(gb), new Random(RNG.Next())); });
            threadC.Start();
            threadC.Join();

            threadD = new Thread(() => { fitness += FitnessThreadMethod((int)sampleSize / 4, new Bitmap(tb), new Bitmap(gb), new Random(RNG.Next())); });
            threadD.Start();
            threadD.Join();
            /*
            threadE = new Thread(() => { fitness += FitnessThreadMethod((int)sampleSize / 8, new Bitmap(tb), new Bitmap(gb), new Random(RNG.Next())); });
            threadE.Start();
            threadE.Join();

            threadF = new Thread(() => { fitness += FitnessThreadMethod((int)sampleSize / 8, new Bitmap(tb), new Bitmap(gb), new Random(RNG.Next())); });
            threadF.Start();
            threadF.Join();

            threadG = new Thread(() => { fitness += FitnessThreadMethod((int)sampleSize / 8, new Bitmap(tb), new Bitmap(gb), new Random(RNG.Next())); });
            threadG.Start();
            threadG.Join();

            threadH = new Thread(() => { fitness += FitnessThreadMethod((int)sampleSize / 8, new Bitmap(tb), new Bitmap(gb), new Random(RNG.Next())); });
            threadH.Start();
            threadH.Join();
            */
            
            //fitness += FitnessThreadMethod(sampleSize, new Bitmap(targetBitmap), new Bitmap(generatedBitmap), new Random(RNG.Next()));

            if (fitness > bestFitness) 
            { 
                bestFitness = (int)fitness;
                bestGenome = genome;
                Console.WriteLine();
                Console.Write(Convert.ToString(fitness) + "  ");
                Console.WriteLine("NEW RECORD!");

                Status.BestBitmap = GenomeToBitmap(bestGenome);
                Status.BestFitness = (int)fitness;
                Status.BestComplexity = bestGenome.Size;
            }

            Console.Write("*");

            Status.CurrentBitmap = generatedBitmap;//GenomeToBitmap(genome);
            Status.CurrentFitness = (int)fitness;
            Status.CurrentComplexity = genome.Size;

            

            worker.ReportProgress(generation, Status);
            //generatedBitmap.Save(Convert.ToString((int)fitness) + "_" + Convert.ToString(RNG.Next()) + ".bmp");

            return (int)fitness;
        }

        private float FitnessThreadMethod(int localSampleSize, Bitmap localTarget, Bitmap localGenerated, Random localRNG)
        {

            float fitness = 0;

            for (int i = 0; i < localSampleSize; i++)
            {
                int rx;
                int ry;


                rx = localRNG.Next(0, (int)localTarget.Width);
                ry = localRNG.Next(0, (int)localTarget.Height);
                

                //Generated Color Values
                byte tRed;
                byte tGreen;
                byte tBlue;
                //byte tAlpha;
                //Generated Color Values
                byte gRed;
                byte gGreen;
                byte gBlue;
                //byte gAlpha;

                //get the target color values
                Color tColor = localTarget.GetPixel(rx, ry);
                tRed = tColor.R;
                tBlue = tColor.B;
                tGreen = tColor.G;

                //get the generated color values
                Color gColor = new Color();
                gColor = localGenerated.GetPixel(rx, ry);
                
                gRed = gColor.R;
                gBlue = gColor.B;
                gGreen = gColor.G;

                //get the color differences
                double RedError = Math.Abs(tRed - gRed);
                double GreenError = Math.Abs(tGreen - gGreen);
                double BlueError = Math.Abs(tBlue - gBlue);

                //=======================================================
                //Actual fitness function
                //-------------------------------------------------------

                float RedGrade = 1.0f - ((float)RedError / (float)255);
                float GreenGrade = 1.0f - ((float)GreenError / (float)255);
                float BlueGrade = 1.0f - ((float)BlueError / (float)255);

                fitness += (float)(Math.Pow((double)(RedGrade + GreenGrade + BlueGrade), (double)3));

                //=======================================================
            }

            return fitness;
        }

        public Bitmap GenomeToBitmap(Genome genome)
        {
            
            int th;
            int tw;

            lock (this)
            {
                tw = targetBitmap.Width;
                th = targetBitmap.Height;
            }

            Bitmap output = new Bitmap(tw, th);
            Graphics g = Graphics.FromImage(output);

            if (style == 0)
            {
                SolidBrush bkg = new SolidBrush(Color.Gray);
                g.FillRectangle(bkg, 0, 0, tw, th);
                int index = 0;
                while (index <= genome.Size)
                {
                    if ((genome.Size - index) >= 8)
                    {

                        int ca = genome[index];
                        index++;
                        int cr = genome[index];
                        index++;
                        int cg = genome[index];
                        index++;
                        int cb = genome[index];
                        index++;
                        int sx = (int)(((float)genome[index] / 255.0f) * (float)tw);
                        index++;
                        int sy = (int)(((float)genome[index] / 255.0f) * (float)th);
                        index++;
                        int sw = (int)(((float)genome[index] / 255.0f) * (float)tw);
                        index++;
                        int sh = (int)(((float)genome[index] / 255.0f) * (float)th);

                        sx -= (int)(sw / 2);
                        sy -= (int)(sh / 2);

                        sw = (int)((float)sw * (1.0f - ((float)index / (float)(genome.Size * 10))));
                        sh = (int)((float)sh * (1.0f - ((float)index / (float)(genome.Size * 10))));

                        Color color = Color.FromArgb(ca, cr, cg, cb);
                        SolidBrush brush = new SolidBrush(color);
                        g.FillRectangle(brush, sx, sy, sw, sh);
                    }

                    index++;
                }
            }

            if (style == 1)
            {
                SolidBrush bkg = new SolidBrush(Color.Gray);
                g.FillRectangle(bkg, 0, 0, tw, th);
                int index = 0;
                while (index <= genome.Size)
                {
                    if ((genome.Size - index) >= 8)
                    {

                        int ca = genome[index];
                        index++;
                        int cr = genome[index];
                        index++;
                        int cg = genome[index];
                        index++;
                        int cb = genome[index];
                        index++;
                        int sx = (int)(((float)genome[index] / 255.0f) * (float)tw);
                        index++;
                        int sy = (int)(((float)genome[index] / 255.0f) * (float)th);
                        index++;
                        int sw = (int)(((float)genome[index] / 255.0f) * (float)tw);
                        index++;
                        int sh = (int)(((float)genome[index] / 255.0f) * (float)th);

                        sx -= (int)(sw / 2);
                        sy -= (int)(sh / 2);

                        sw = (int)((float)sw * (1.0f - ((float)index / (float)(genome.Size * 10))));
                        sh = (int)((float)sh * (1.0f - ((float)index / (float)(genome.Size * 10))));

                        Color color = Color.FromArgb(ca, cr, cg, cb);
                        SolidBrush brush = new SolidBrush(color);
                        g.FillEllipse(brush, sx, sy, sw, sh);
                    }

                    index++;
                }
            }

            return output;
        }




        public static void ShowConsoleWindow()
        {
            var handle = GetConsoleWindow();

            if (handle == IntPtr.Zero)
            {
                AllocConsole();
            }
            else
            {
                ShowWindow(handle, SW_SHOW);
            }
        }

        public static void HideConsoleWindow()
        {
            var handle = GetConsoleWindow();

            ShowWindow(handle, SW_HIDE);
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
    }
}
