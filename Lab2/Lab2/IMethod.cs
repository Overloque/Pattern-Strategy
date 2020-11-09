using System;

namespace Lab2
{
    interface IMethod
    {
        public double Execute(Func<double, double> f, double a, double b, Func<double, double> Df = null);
    }
}
