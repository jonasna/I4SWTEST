﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion01
{
    public class Calculator
    {
        public double Add(double a, double e)
        {
            return a + e;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }
    }
}
