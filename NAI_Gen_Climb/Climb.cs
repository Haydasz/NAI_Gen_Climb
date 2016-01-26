using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAI_Gen_Climb
{
    class Climb
    {
        private int iteration;
        private int func;
        //private double min;
        //private double max;
        private double startPoint;
        private double delta;
        private List<string> ret;

        public Climb(int iteration, int func, double min, double max, double startPoint, double delta)
        {
            this.iteration = iteration;
            this.func = func;
            //this.min = min;
           // this.max = max;
            this.startPoint = startPoint;
            this.delta = delta;
        }

        internal List<String> run()
        {
            int idx, /* idy*/ minIter = 0;
            double f, minimum; // x, y;
            double[] probeArray = new double[2];
     

            

            minimum = Double.MaxValue;

            for (idx = 0; idx < iteration; idx++)
            {
                probeArray = this.getProbe(delta);

                /* switch (func)
                 {
                     case 0:
                         f = Functions.funcTest1(probeArray[0], probeArray[1]);
                         break;
                     case 1:
                         f = Functions.funcGeem(probeArray[0], probeArray[1]);
                         break;
                     case 2:
                         f = Functions.funcMatyas(probeArray[0], probeArray[1]);
                         break;
                     case 3:
                         f = Functions.funcBeala(probeArray[0], probeArray[1]);
                         break;
                     default:
                         f = Functions.funcTest1(probeArray[0], probeArray[1]);
                         break;
                 }*/
                f = Functions.functionCreate(probeArray[0], probeArray[1]);

                if (f < minimum)
                {
                    minimum = f;
                    minIter = idx;

                    ret = new List<string>();

                    ret.Add(minimum.ToString());
                    ret.Add(minIter.ToString());
                    ret.Add(probeArray[0].ToString());
                    ret.Add(probeArray[1].ToString());
                }

                if (probeArray[0] < probeArray[1])
                    startPoint = probeArray[0];
                else
                    startPoint = probeArray[1];
            }

            Console.WriteLine(minimum);
            Console.WriteLine(minIter);

            return ret;
        }

        private double[] getProbe(double delta)
        {
            Random random = new Random();
            double[] probeArray = new double[2];

            probeArray[0] = startPoint + delta;
            probeArray[1] = startPoint - delta;

            return probeArray;
        }
    }
}
