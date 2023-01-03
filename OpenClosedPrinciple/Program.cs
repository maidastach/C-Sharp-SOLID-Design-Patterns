/*
            *** OPEN CLOSED PRINCIPLE ***
 * A Class should be OPEN for extensions but CLOSED for modifications
 * 
 * In this simple application i am creating a list of applicants
 * fetching their first and last names (PersonModel)
 * then through the accountProcessor i register each of the applicants
 * as employee (EmployeeModel) and create an email address for them
 * 
 * Let's suppose that this app is in production, and a new scenario 
 * comes up, like we should be able to identify if an employee 
 * is a Manager or an Executive. We should not change the Accounts 
 * processor because it works, we would rather extend it through Interfaces.
 * 
 * We start extending the EmployeeModel adding IsManager 
 * and IsExecutive props defaulted on false
 * and extending the PersonModel by initialising an AccountProcessor into it
 * 
 * We then create 2 Model and 2 AccountProcessor 
 * one for Manager and one for Executive
 * Each of the Model and AccountProcessor will have 
 * the respective default instance
 * 
 * In this way we have opened our application for extensions to any other
 * role/position which an employee may have
 * 
 */

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Salvatore", LastName= "De Rosa" },
                new PersonModel { FirstName = "Giovanni", LastName= "Esposito" },
                new PersonModel { FirstName = "Marek", LastName= "Hamsik" },
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var applicant in applicants)
            {
                employees.Add(accountProcessor.Create(applicant));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.Email}");
            }

            Console.ReadLine();

        }
    }
}