using OpenClosedPrinciple.Accounts_;

namespace OpenClosedPrinciple.Applicants
{
    internal class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccounts AccountProcessor { get; set; } = new Accounts();

    }
}