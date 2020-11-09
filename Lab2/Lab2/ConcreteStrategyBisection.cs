using System;
using System.Linq;

namespace Lab2
{
    class ConcreteStrategyBisection : IMethod
    {
        const int N = 25;
        public double Execute(Func<double, double> f, double a, double b, Func<double, double> Df = null)
        {
            if(f(a) * f(b) >= 0)
            {
                Console.WriteLine("Bisection method fails");
                return 0;
            }

            double a_n = a;
            double b_n = b;

            foreach (int n in Enumerable.Range(1, N))
            {
                double mid_n = (a_n + b_n) / 2;
                double f_mid_n = f(mid_n);

                if (f(a_n) * f_mid_n < 0)
                {
                    b_n = mid_n;
                } 
                else if (f(b_n) * f_mid_n < 0)
                {
                    a_n = mid_n;
                } 
                else if (f_mid_n == 0)
                {
                    Console.WriteLine("Solution is found!");
                    return mid_n;
                } 
                else
                {
                    Console.WriteLine("Bisection method fails");
                    return 0;
                }
            }
            return (a_n + b_n) / 2;
        }
    }
}
