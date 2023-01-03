/*
 *             *** DEPENDENCY INVERSION PRINCIPLE ***
 * 
 * The DIP states that high level modules should not depend on low
 * level modules but rather both should depend on abstractions and
 * those abstractions should not depend on details.
 * Meaning those abstractions should not have to know about how
 * things get done, they should just say these are the things
 * that will get done.
 * 
 * In this example the Main method (high level module) calls 
 * on the Person class as well as th Chore class, it means 
 * it depends on both those classes being there.
 * 
 * However the Chore class is also an high level module
 * because it depends on the Logger and Emailer classes.
 * 
 * Which means every changes on the low level modules will
 * be reflected to the high level modules and may cause 
 * some issue. Hence we need to invert this through Interfaces.
 * As well as we need to remove all those new Instances throughout
 * the application, and so collecting them in a single class.
 * 
 * As for example i have swapped the email service with a texting
 * service changing it in just one part, the change did not bring
 * any issue because the app was not depending directly on that
 * instantiation.
 * That is the benefit of creating modular code.
 * 
 */

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