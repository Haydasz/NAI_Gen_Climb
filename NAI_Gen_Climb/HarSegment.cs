using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAI_Gen_Climb
{
    class HarSegment
    {

        public double x1;
        public double x2;
        public double wynik { get { return Functions.functionCreate(x1, x2); } }
        //
        public HarSegment(double min, double max)
        {
            Random rand = new Random();
            //HMi(d) = LB(d) + (UB(d) – LB(d))  rand() for i = 0 to HMS – 1 and d = 0 to D

            x1 = min + (max - min) * rand.NextDouble();
            x2 = min + (max - min) * rand.NextDouble();
        }
    }
}
