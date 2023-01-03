namespace DependencyInversionPrinciple
{
    internal class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console { message }");
        }
    }
}