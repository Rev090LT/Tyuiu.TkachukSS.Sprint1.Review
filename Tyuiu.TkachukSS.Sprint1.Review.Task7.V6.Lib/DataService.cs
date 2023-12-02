﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TkachukSS.Sprint1.Review.Task7.V6.Lib
{
    public class DataService : ISprint1Task7V6
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(1 + (1 / Math.Pow(x, 2)), x) - (12 * Math.Pow(x, 2) * y);
            return res;
        }
    }
}
