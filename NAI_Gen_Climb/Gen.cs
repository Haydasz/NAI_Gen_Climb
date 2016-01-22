using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAI_Gen_Climb
{

    class Gen
    {
        static Random random = new Random();
        private int popSize; //wielkosc populacji
        private int iteration; //ilosc iteracji
        private int func; //funkcja
        private double min; //dolny zakres
        private double max; //gorny zakres
        List<Czlon> pop; //populacja
        private List<string> ret;

        public Gen(int popSize, int iteration, int func, double min, double max)
        {
            this.popSize = popSize;
            this.iteration = iteration;
            this.func = func;
            this.min = min;
            this.max = max;
        }

        public List<String> runGen()
        {
            int idx, idy, minIter = 0;
            double y, minimum;
           

            minimum = Double.MaxValue;
            pop = this.initPop(min, max, popSize); //inicjalizacja populacji

            for (idx = 0; idx < iteration; idx++)
            {
                pop = Selection(pop);
                pop = Crossover(pop);
                pop = Mutate(pop);

                pop.OrderBy(x => x.wynik);
                if (pop[0].wynik < minimum)
                {
                    ret = new List<string>();

                    minimum = pop[0].wynik;
                    minIter = idx;
                    ret.Add(minimum.ToString());
                    ret.Add(minIter.ToString());
                    ret.Add(pop[0].x1.ToString());
                    ret.Add(pop[0].x2.ToString());
                }

            }

           
            Console.WriteLine(minimum);
            Console.WriteLine(minIter);

            
            return ret;
        }



        private List<Czlon> Mutate(List<Czlon> list)
        {
            foreach (var item in list)
            {
                int mutate = random.Next(100);
                var mutation = new byte[8];
                if (mutate >= 99)
                {
                    int whichAllel = random.Next(1);
                    if (whichAllel == 0)
                        mutation = BitConverter.GetBytes(item.x1);
                    else
                        mutation = BitConverter.GetBytes(item.x2);

                    int whichPlace = random.Next(0, 7);

                    mutation[whichPlace] = (byte)random.Next(0, 255);

                    if (whichAllel == 0)
                        item.x1 = BitConverter.ToDouble(mutation, 0);
                    else
                        item.x2 = BitConverter.ToDouble(mutation, 0);
                }
            }

            return list;
        }

        private List<Czlon> Crossover(List<Czlon> list)
        {
            int locus;
            var parentList = new List<Czlon>();

            foreach (var item in list)
            {
                if (random.Next() % 100 > 50) parentList.Add(item);
            }
            if (parentList.Count % 2 != 0) parentList.Remove(parentList[0]);

            for (int i = 0; i < parentList.Count / 2; i = i + 2)
            {
                list.Remove(parentList[i]);
                list.Remove(parentList[i + 1]);
                var parentOneX = BitConverter.GetBytes(parentList[i].x1);
                var parentOneY = BitConverter.GetBytes(parentList[i].x2);
                var parentTwoX = BitConverter.GetBytes(parentList[i + 1].x1);
                var parentTwoY = BitConverter.GetBytes(parentList[i + 1].x2);

                locus = random.Next(7);
                var childOneX = new byte[8];
                var childOneY = new byte[8];
                var childTwoX = new byte[8];
                var childTwoY = new byte[8];

                for (int j = 0; j < 8; j++)
                {
                    if (j <= locus)
                    {
                        childOneX[j] = parentOneX[j];
                        childOneY[j] = parentOneY[j];
                        childTwoX[j] = parentTwoX[j];
                        childTwoY[j] = parentTwoY[j];
                    }
                    else
                    {
                        childOneX[j] = parentTwoX[j];
                        childOneY[j] = parentTwoY[j];
                        childTwoX[j] = parentOneX[j];
                        childTwoY[j] = parentOneY[j];
                    }
                }

                var childOne = new Czlon(childOneX, childOneY);
                list.Add(childOne);

                var childTwo = new Czlon(childTwoX, childTwoY);
                list.Add(childTwo);

            }

            return list;
        }

        private List<Czlon> Selection(List<Czlon> list)
        {
            var tempList = new List<Czlon>();
            list = list.OrderBy(x => x.wynik).ToList();
            int listCount = list.Count - 2;
            tempList.Add(list[0]);
            tempList.Add(list[1]);

            for (int i = 0; i < listCount; i++)
            {
                int rand1 = random.Next(0, listCount);
                int rand2 = random.Next(0, listCount);

                if (list[rand1].wynik > list[rand2].wynik)
                    tempList.Add(list[rand2]);
                else
                    tempList.Add(list[rand1]);
            }

            return tempList;
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