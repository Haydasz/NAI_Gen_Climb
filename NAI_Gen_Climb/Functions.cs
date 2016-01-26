using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAI_Gen_Climb
{
    class Functions
    {
        public static int functionChoice;

        public static double funcGeem(Double _x1, Double _x2)
        {
            double ret;

            ret = 4 * (Math.Pow(_x1, 2)) - ((2.1) * (Math.Pow(_x1, 4))) + ((Math.Pow(_x1, 6)) / 3) + _x1 * _x2 - (4 * (Math.Pow(_x2, 2))) + (4 * (Math.Pow(_x2, 4)));
          //  Console.WriteLine(ret);
            return ret;
        }

        public static double funcTest1(Double _x1, Double _x2)
        {
            double ret;
            //_x1 = 0.0;
            // _x2 = 1.0;

            ret = Math.Pow(_x1, 2) + (_x1 * _x2) + 0.5 * (Math.Pow(_x2, 2)) - _x1 - _x2;

            return ret;
        }

        public static double funcMatyas(Double _x1, Double _x2)
        {
            double ret;
            //x1 = 0;
            //_x2 = 0;

            ret = 0.26 * (Math.Pow(_x1, 2) + Math.Pow(_x2, 2)) - 0.48 * _x1 * _x2;

            return ret;
        }

        public static double funcBeala(Double _x1, Double _x2)
        {
            double ret;

            ret = Math.Pow((1.5 - _x1 + _x1 * _x2), 2) + Math.Pow(2.25 - _x1 + Math.Pow((_x1 * _x2),2), 2) + Math.Pow(2.625 - _x1 + Math.Pow((_x1 * _x2), 3), 2);

            return ret;
        }

        public static double functionCreate(double x, double y)
        {
            double f;

            switch (functionChoice)
            {
                case 0:
                    f = funcTest1(x, y);
                    break;
                case 1:
                    f = funcGeem(x, y);
                    break;
                case 2:
                    f = funcMatyas(x, y);
                    break;
                case 3:
                    f = funcBeala(x, y);
                    break;
                default:
                    f = funcTest1(x, y);
                    break;
            }
            return f;
        }
    }
}
