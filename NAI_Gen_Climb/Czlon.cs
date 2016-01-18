﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAI_Gen_Climb
{
    class Czlon
    {
        public double x1;
        public double x2;
        public double wynik { get { return Math.Pow(x1, 2) + (x1 * x2) + 0.5 * (Math.Pow(x2, 2)) - x1 - x2; } }
        //
        public Czlon(double min, double max)
        {
            x1 = Gen.RandomZZakresu(min, max);
            x2 = Gen.RandomZZakresu(min, max);
        }

        public Czlon(byte[] x, byte[] y)
        {
            x1 = BitConverter.ToDouble(x, 0);
            x2 = BitConverter.ToDouble(y, 0);
        }
    }
}