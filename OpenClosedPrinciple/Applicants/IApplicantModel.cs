using OpenClosedPrinciple.Accounts_;

namespace OpenClosedPrinciple.Applicants
{
    internal interface IApplicantModel
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccounts AccountProcessor { get; set; }
    }
}