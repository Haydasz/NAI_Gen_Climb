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
        private double min;
        private double max;

        public Climb(int iteration, int func, double min, double max)
        {
            this.iteration = iteration;
            this.func = func;
            this.min = min;
            this.max = max;
        }

        internal void run()
        {
            int idx, idy, minIter = 0;
            double f, minimum, x, y;
            double[] probeArray = new double[2];

            minimum = Double.MaxValue;

            for (idx = 0; idx < iteration; idx++)
            {
                probeArray = this.getProbe();
                f = Program.funcTest1(probeArray[0], probeArray[1]);

                if (f < minimum)
                {
                    minimum = f;
                    minIter = idx;
                }
            }

            Console.WriteLine(minimum);
            Console.WriteLine(minIter);
        }

        private double[] getProbe()
        {
            Random random = new Random();
            double[] probeArray = new double[2];

            probeArray[0] = random.NextDouble() * (max - min) + min;
            probeArray[1] = random.NextDouble() * (max - min) + min;

            return probeArray;
        }
    }
}
