using OpenClosedPrinciple.Applicants;

namespace OpenClosedPrinciple.Accounts_
{
    internal class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.Email = $"{person.FirstName.Replace(" ", "")}.{person.LastName.Replace(" ", "")}@executive.au"; 
            output.IsManager = true;
            output.IsExecutive = true;

            return output;
        }
    }
}