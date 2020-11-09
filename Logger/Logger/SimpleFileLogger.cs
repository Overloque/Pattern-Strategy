using System.IO;

namespace Logger
{
    class SimpleFileLogger : ILogger
    {
        public void Log(string message)
        {
            string path = "simpleJournal.txt";
            File.AppendAllText(path, "Message: " + message + "\n");
        }
    }
}
