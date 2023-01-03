/*
            *** LISKOV SUBSTITUTION PRINCIPLE ***
 *  
 * The LSP says that a child Class which inherit from a parent one
 * should be able to implement all of the characteristics
 * without breaking the application.
 * 
 * In our case CEO inherit from Employee however if we create
 * a new CEO with an Employee interface it breaks because
 * CEO cannot be assigned a Manager.
 * 
 * We do create a BaseEmployee class which includes the properties
 * and methods in common between CEO Manager and Employee
 * and make Employee inherit from it
 * 
 * We also create some interfaces for all the spares properties
 * and methods which applies to different classes so we can implement
 * them over the respective class
 * 
 * In this way we can play around with the newly created interfaces
 * without breaking the app.
 * 
 */

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Salvatore";
            accountingVP.LastName = "De Rosa";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Employee();

            emp.FirstName = "Marek";
            emp.LastName = "Hamsik";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");

            Console.ReadLine();
        }
    }
}