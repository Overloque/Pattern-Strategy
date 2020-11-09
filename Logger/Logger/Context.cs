namespace Logger
{
    class Context
    {
        public ILogger Strategy { get; set; }

        public void ExecuteStrategy(string message)
        {
            Strategy.Log(message);
        }
    }
}
