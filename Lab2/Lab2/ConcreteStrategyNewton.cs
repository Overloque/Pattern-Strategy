using System;
using System.Linq;

namespace Lab2
{
    class ConcreteStrategyNewton : IMethod
    {
        public double Execute(Func<double, double> f, double x0, double _, Func<double, double> Df = null)
        {
            const int N = 10;
            double xn = x0;
            const double eps = 1e-8;

            foreach (int n in Enumerable.Range(1, N))
            {
                double fxn = f(xn);
                if (Math.Abs(fxn) < eps)
                {
                    Console.WriteLine($"Solution is found after {n - 1} iterations");
                    return xn;
                }
                double Dfxn = Df(xn);
                if (Dfxn == 0)
                {
                    Console.WriteLine($"Derivative equals 0. No solution found.");
                    return 0;
                }
                xn = xn - fxn / Dfxn;
            }
            Console.WriteLine("Count of iterations is maximum");
            return 0;
        }
    }
}
