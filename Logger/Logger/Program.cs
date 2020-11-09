using System;
using System.Collections.Generic;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            List<string> list = new List<string>();
            string message;

            do
            {
                Console.Write("Write down a message for journal: ");
                message = Console.ReadLine();
                if (message != "f")
                {
                    list.Add("Message: " + message);

                    context.Strategy = new ConsoleLogger();
                    context.ExecuteStrategy(message);

                    context.Strategy = new SimpleFileLogger();
                    context.ExecuteStrategy(message);

                    context.Strategy = new TimedFileLogger();
                    context.ExecuteStrategy(message);
                }
            } while (message != "f");

            Console.WriteLine("\nJournal\n-------------------------------");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
