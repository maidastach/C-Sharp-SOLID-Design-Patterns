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