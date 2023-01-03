using OpenClosedPrinciple.Applicants;

namespace OpenClosedPrinciple.Accounts_
{
    internal interface IAccounts
    {
        public EmployeeModel Create(IApplicantModel person);
    }
}
