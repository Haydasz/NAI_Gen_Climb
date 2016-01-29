using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAI_Gen_Climb
{
    class Harmony
    {
        private int hsm;
        private double hmcr;
        private double par;
        private double min;
        private double max;
        private int iteration;
        private List<string> ret;
        private double bw = 0.2;

        public Harmony(int hsm, double hmcr, double par, double min, double max, int iteration)
        {
            this.hsm = hsm;
            this.hmcr = hmcr;
            this.par = par;
            this.min = min;
            this.max = max;
            this.iteration = iteration;
        }

        public List<String> run()
        {
            List<HarSegment> memory;
            HarSegment trial;
            int iter, d;
            Random rand = new Random();
            memory = initMemory(hsm);

            for (iter = 0; iter<iteration; iter ++)
            {
                trial = memory[rand.Next(0, hsm - 1)];
              //  for (d = 0; d < 2; d++)
                //{
                    
                    if (rand.NextDouble() < hmcr)
                    {
                        //trial = memory[rand.Next(0, hsm-1)];
                        if (rand.NextDouble() < par)
                        {
                        //          if(d == 0)
                        var x = rand.NextDouble() * (1 + 1) - 1;
                                trial.x1 = trial.x1 + (rand.NextDouble() * (1 + 1) -1) * bw; 
                    //        else
                                trial.x2 = trial.x2 + (rand.NextDouble() * (1 + 1) - 1) * bw;
                        }
                    }
                    else
                    {
                      //  if (d == 0)
                            trial.x1 = min + (max - min) * rand.NextDouble();
                        //else
                            trial.x2 = min + (max - min) * rand.NextDouble();
                    }
                //}
                memory = fitness(memory, trial);
            }

           // ret.Add("hguyg");

            return ret;
        }

        private List<HarSegment> fitness(List<HarSegment> memory ,HarSegment trial)
        {
            var temp = memory.OrderBy(x => x.wynik).ToList();
            if (temp[hsm-1].wynik > trial.wynik)
            {
                /* ret = new List<string>();

                 minimum = pop[0].wynik;
                 minIter = idx;
                 ret.Add(minimum.ToString());
                 ret.Add(minIter.ToString());
                 ret.Add(pop[0].x1.ToString());
                 ret.Add(pop[0].x2.ToString());*/
                temp[hsm-1] = trial;
            }

            return temp;
        }

        private List<HarSegment> initMemory(int hsm)
        {
            int i;
            var tempList = new List<HarSegment>();
            

            for (i=0; i< hsm; i++)
            {
                tempList.Add(new HarSegment(min, max));
            }

            return tempList;
        }
    }
}
