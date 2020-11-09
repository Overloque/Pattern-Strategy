using System;

namespace Lab2
{
    class Context
    {
        public IMethod Strategy { get; set; }
        public double ExecuteStrategy(Func<double, double> f, double a, double b, Func<double, double> Df = null)
        {
            return Strategy.Execute(f, a, b, Df);
        }
    }
}
