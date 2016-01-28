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
                for (d = 0; d < 2; d++)
                {
                    if (rand.NextDouble() < hmcr)
                    {
                        trial = memory[rand.Next()];
                    }
                    else
                    {
                        if (d)
                    }
                }
            }

            ret.Add("hguyg");

            return ret;
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
