using System;
using System.IO;

namespace Logger
{
    class TimedFileLogger : ILogger
    {
        public void Log(string message)
        {
            string path = "timedJournal.txt";
            File.AppendAllText(path, DateTime.Now + " " + "Message: " + message + "\n");
        }
    }
}
