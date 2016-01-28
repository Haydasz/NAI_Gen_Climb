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
        private List<string> ret;

        public Harmony(int hsm, double hmcr, double par, double min, double max)
        {
            this.hsm = hsm;
            this.hmcr = hmcr;
            this.par = par;
            this.min = min;
            this.max = max;
        }

        public List<String> run()
        {
            List<HarSegment> memory;
            memory = initMemory(hsm);

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
