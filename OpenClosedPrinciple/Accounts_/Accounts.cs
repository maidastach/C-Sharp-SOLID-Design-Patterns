using OpenClosedPrinciple.Applicants;

namespace OpenClosedPrinciple.Accounts_
{
    internal class Accounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.Email = $"{person.FirstName.Replace(" ", "").Substring(0, 1)}{person.LastName.Replace(" ", "")}@employee.au";
            
            return output;
        }
    }
}