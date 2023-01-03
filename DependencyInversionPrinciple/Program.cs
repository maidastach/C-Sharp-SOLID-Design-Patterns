namespace DependencyInversionPrinciple
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Salvatore",
                LastName = "De Rosa",
                EmailAddress = "salva@derosa.com",
                PhoneNumber = "1234567890",
            };

            Chore chore = new Chore
            {
                ChoreName = "Take out the trash",
                Owner = owner,
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}