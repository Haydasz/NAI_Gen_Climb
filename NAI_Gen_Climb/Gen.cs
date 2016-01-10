﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAI_Gen_Climb
{
    public class Czlon
    {
        double x1;
        double x2;
        double wynik;

        public Czlon(double min , double  max)
        {
            x1 = Gen.RandomZZakresu(min, max);
            x2 = Gen.RandomZZakresu(min, max);
        } 

    }
    class Gen
    {
        static Random random = new Random();
        private int popSize; //wielkosc populacji
        private int iteration; //ilosc iteracji
        private int func; //funkcja
        private double min; //dolny zakres
        private double max; //gorny zakres
        List<Czlon> pop; //populacja


        public Gen(int popSize, int iteration, int func, double min, double max)
        {
            this.popSize = popSize;
            this.iteration = iteration;
            this.func = func;
            this.min = min;
            this.max = max;
        }

        public void runGen()
        {
            int idx, idy, minIter = 0;
            double y, minimum;
           // Map 

            minimum = Double.MaxValue;
            pop = this.initPop(min, max, popSize); //inicjalizacja populacji

            for (idx=0; idx<iteration; idx++)
            {
                //Selection();
                //Crossover();
               // Mutate();

            }

            Console.WriteLine(minimum);
            Console.WriteLine(minIter);
        }

        private double[] crossPopulation(double[] pop)
        {
            var list = new List<byte[]> { };
            var listNew = new List<byte[]> { };
            double[] ret = new double[popSize];
            
            byte[] pop1 = new byte[8];
            byte[] pop2 = new byte[8];
            Random random = new Random();
            int locus = random.Next(7);
            int idx;

            list = bytePopulation(pop); //inicjalizacja chromosomów z populacji

            for (idx = 2; idx < list.Count; idx=idx+2)
            {
                pop1= list[idx-1];
                pop2 = list[idx];

                listNew = this.crossChromosome(pop1, pop2, locus, listNew);
            }

            ret = debytePopulation(listNew);

            return ret;
        }

        private double[] debytePopulation(List<byte[]> listNew)
        {
            double result;
            double[] newPop = new double[popSize];
            int idx = 0;

            foreach (var iter in listNew)
            {
               result =  BitConverter.ToDouble(iter, 0);
                newPop[idx] = result;
                idx++;
            }

            return newPop;
        }

        private List<byte[]> crossChromosome(byte[] pop1, byte[] pop2, int locus, List<byte[]> list)
        {
            byte[] tempArr = new byte[8];
            byte[] tempArr2 = new byte[8];
            int idx;

            tempArr = pop1;
            tempArr2 = pop2;

            for (idx = locus; idx < 8; idx++)
            {
                pop1[idx] = tempArr2[idx];
                pop2[idx] = tempArr[idx];
            }


            list.Add(pop1);
            list.Add(pop2);
            return list;
        }

        private List<byte[]> bytePopulation(double[] pop)
        {
            var list = new List<byte[]> { };
            byte[] array;
            int idx;

            for (idx = 0; idx < pop.Length; idx++)
            {
                array = BitConverter.GetBytes(pop[idx]);
                list.Add(array);
            }

            return list;
        }

        private List<Czlon> initPop(double min, double max, int popSize)
        {
            var tempList = new List<Czlon>();
            for (int idx = 0; idx < popSize; idx++)
            {
                tempList.Add(new Czlon(min, max));
            }
            return tempList;
        }

        public static double RandomZZakresu(double min, double max)
        {
            return random.NextDouble() * (max - min) + min;
        }
    }
}
