/*
            *** SINGLE RESPONSIBILITY PRINCIPLE ***
 * A Class should have ONE responsibility or ONE reason to change
 * 
 * In this example if i want to change the way i welcome users
 * or the way i fetch their details i would break this rule.
 * 
 * Hence i break the following class into "sections"
 * eache of which will have one responsibility (does one job)
 * and in case it will have to change 
 * it will be only for one reason
 *
 * We will have more classes however they can be
 * organised into folders
 *
 */

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application");

            // Ask for user information
            Person user = new Person();

            Console.Write("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.LastName = Console.ReadLine();

            // Checks to be sure the first and last name are valid
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give us a valid first name!");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give us a valid last name!");
                Console.ReadLine();
                return;
            }

            // Create a username for the user
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
            Console.ReadLine();
        }
    }
}