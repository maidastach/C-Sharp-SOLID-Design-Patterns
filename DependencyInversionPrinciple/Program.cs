using DependencyInversionPrinciple.Chore_;
using DependencyInversionPrinciple.Person_;

namespace DependencyInversionPrinciple
{
    class Program
    {
        public static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Salvatore";
            owner.LastName = "De Rosa";
            owner.EmailAddress = "salva@derosa.com";
            owner.PhoneNumber = "1234567890";

            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}