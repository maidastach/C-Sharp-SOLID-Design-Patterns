namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new CEO();

            accountingVP.FirstName = "Salvatore";
            accountingVP.LastName = "De Rosa";
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Manager();

            emp.FirstName = "Marek";
            emp.LastName = "Hamsik";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour. His manager is: { emp.Manager.FirstName } whose salary is: ${ emp.Manager.Salary }/hour.");

            Console.ReadLine();
        }
    }
}