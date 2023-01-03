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