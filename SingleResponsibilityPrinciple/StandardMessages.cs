namespace SingleResponsibilityPrinciple
{
    internal class StandardMessages
    {
        public static void WelcomeMessage() 
        {
            Console.WriteLine("Welcome to my application");
        }

        public static void EndApplication() 
        {
            Console.Write("Press Enter To Close...");
            Console.ReadLine();
        }

        public static void ValidationError(string property) 
        { 
            Console.WriteLine($"You did not give us a valid { property }!");
        }

    }
}