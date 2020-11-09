using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> f = x => Math.Pow(x, 2) - x - 1;
            Func<double, double> Df = x => 2 * x - 1;

            Context context = new Context();
            context.Strategy = new ConcreteStrategyBisection();
            var result = context.ExecuteStrategy(f, 1, 2);
            Console.WriteLine(result);

            context.Strategy = new ConcreteStrategySecant();
            result = context.ExecuteStrategy(f, 1, 2);
            Console.WriteLine(result);

            context.Strategy = new ConcreteStrategyNewton();
            result = context.ExecuteStrategy(f, 1, 0, Df);
            Console.WriteLine(result);
        }
    }
}
