using SingleResponsibilityPrinciple.Person_;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            // Ask for user information
            Person user = PersonFetcherData.FetchData();

            // Checks to be sure the first and last name are valid
            bool isUserValid = PersonValidation.Validate(user);
            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Create a username for the user
            AccountGenerator.Generate(user);
            StandardMessages.EndApplication();
        }
    }
}