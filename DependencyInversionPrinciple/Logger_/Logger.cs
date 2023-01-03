namespace DependencyInversionPrinciple.Logger_
{
    internal class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console {message}");
        }
    }
}