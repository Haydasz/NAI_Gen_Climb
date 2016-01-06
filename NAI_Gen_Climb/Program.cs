using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NAI_Gen_Climb
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static double funcGeem(Double _x1, Double _x2)
        {
            double ret;

            ret = 4 * (Math.Pow(_x1, 2)) - ((2.1) * (Math.Pow(_x1, 4))) + ((Math.Pow(_x1, 6)) / 3) + _x1 * _x2 - (4 * (Math.Pow(_x2, 2))) + (4 * (Math.Pow(_x2, 4)));
            Console.WriteLine(ret);
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
    }
}
