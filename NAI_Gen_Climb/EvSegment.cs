using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAI_Gen_Climb
{
    class EvSegment
    {
        public double x1;
        public double x2;
        public double wynik { get { return Functions.functionCreate(x1, x2); } }
        //
        public EvSegment(double min, double max)
        {
            x1 = Evolution.RandomFrom(min, max);
            x2 = Evolution.RandomFrom(min, max);
        }

        public EvSegment(byte[] x, byte[] y)
        {
            x1 = BitConverter.ToDouble(x, 0);
            x2 = BitConverter.ToDouble(y, 0);
        }
    }
}
