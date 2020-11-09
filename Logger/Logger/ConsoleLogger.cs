using System;

namespace Logger
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Message: " + message + "\n");
        }
    }
}
