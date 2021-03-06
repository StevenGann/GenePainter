﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenePainter
{
    public class Genome
    {
        private List<byte> geneList;
        private Random RNG;

        public int Fitness = -1;

        public int Size
        {
            get { return geneList.Count; }
        }

        public byte this[int i]
        {
            get { return geneList[i]; }
        }


        //===============================================================
        // Constructors
        //---------------------------------------------------------------
        public Genome(int s, int seed)
        {
            RNG = new Random(seed);

            //New random genome
            geneList = new List<byte>(s);

            for (int i = 0; i < s; i++)
            {
                //geneList[i] = (byte)RNG.Next(256);
                geneList.Insert(i, (byte)RNG.Next(256));
                //geneList.Add((byte)RNG.Next(256));
            }

            Fitness = -1;
        }

        public Genome(Genome parentA, Genome parentB, int seed)
        {
            RNG = new Random(seed);
            //New genome based on two parents

            geneList = new List<byte>(Math.Max(parentA.Size, parentB.Size));

            int i = 0;
            int overlap = Math.Min(parentA.Size, parentB.Size);

            while (i <= overlap - 1)
            {
                geneList.Insert(i, Combine(parentA[i], parentB[i]));
                i++;
            }

            if (parentA.Size > parentB.Size)
            {
                while (i <= Math.Max(parentA.Size, parentB.Size) - 1)
                {
                    geneList.Insert(i, parentA[i]);
                    i++;
                }
            }

            if (parentA.Size < parentB.Size)
            {
                while (i <= Math.Max(parentA.Size, parentB.Size) - 1)
                {
                    geneList.Insert(i, parentB[i]);
                    i++;
                }
            }

            Fitness = -1;
        }

        //===============================================================
        // Genome manipulation methods
        //---------------------------------------------------------------

        public byte Combine(byte geneA, byte geneB)
        {
            byte result = 0;

            int choice = RNG.Next(3);

            //Average the two
            if (choice == 0)
            {
                result = (byte)((float)(geneA + geneB) / 2);
            }

            //Pick a value between the two
            if (choice == 1)
            {
                result = (byte)RNG.Next(Math.Min(geneA, geneB), Math.Max(geneA, geneB));
            }

            //Just return A
            if (choice == 2)
            {
                result = geneA;
            }

            //Just return B
            if (choice == 3)
            {
                result = geneB;
            }


            return result;
        }

        //Make small random changes to the genome
        public void Mutate(int rate)
        {
            for (int i = 0; i < Size; i++)
            {
                if (RNG.Next(100) <= rate)
                {
                    //Shift a value over
                    geneList[i] += (byte)RNG.Next(255 - (int)geneList[i]);
                    geneList[i] -= (byte)RNG.Next((int)geneList[i]);
                }

                if (RNG.Next(100) <= rate)
                {
                    //Nudge a value a bit
                    geneList[i] += (byte)RNG.Next(rate);
                    geneList[i] -= (byte)RNG.Next(rate);
                }

                if (RNG.Next(100) <= (rate/2))
                {
                    //Swap some values
                    int n = RNG.Next(100);
                    if (n <= 50){ n = 8;}
                    else{ n = -8;}
                    if (i + n > geneList.Count - 1) { n = -8; }
                    if (i + n < 0) { n = 8; }
                    byte a = geneList[i];
                    geneList[i] = geneList[i + n];
                    geneList[i + n] = a;
                }

                if (RNG.Next(100) <= (rate / 4))
                {
                    //Totally random value!
                    geneList[i] = (byte)(((float)RNG.Next(byte.MaxValue) + (float)RNG.Next(byte.MaxValue))/2.0f);
                }
            }
        }


    }
}
