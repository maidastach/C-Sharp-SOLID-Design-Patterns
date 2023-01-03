using OpenClosedPrinciple.Applicants;

namespace OpenClosedPrinciple.Accounts_
{
    internal class ManagerAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.Email = $"{person.FirstName.Replace(" ", "").Substring(0, 1)}{person.LastName.Replace(" ", "")}@manager.au";
            output.IsManager = true;

            return output;
        }
    }
}