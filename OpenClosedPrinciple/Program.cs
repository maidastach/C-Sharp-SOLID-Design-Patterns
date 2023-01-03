using OpenClosedPrinciple.Applicants;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel { FirstName = "Salvatore", LastName= "De Rosa" },
                new ManagerModel { FirstName = "Giovanni", LastName= "Esposito" },
                new ExecutiveModel { FirstName = "Marek", LastName= "Hamsik" },
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var applicant in applicants)
            {
                employees.Add(applicant.AccountProcessor.Create(applicant));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.Email} isManager: {emp.IsManager} isExecutive: {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }
}