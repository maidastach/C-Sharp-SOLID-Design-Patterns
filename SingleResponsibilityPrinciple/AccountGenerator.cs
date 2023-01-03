using SingleResponsibilityPrinciple.Person_;

namespace SingleResponsibilityPrinciple
{
    internal class AccountGenerator
    {
        public static void Generate(Person user)
        {
            Console.WriteLine($"Your username is {RemoveWhiteSpaces(user.FirstName).Substring(0, 1)}{RemoveWhiteSpaces(user.LastName)}");
        }

        private static string RemoveWhiteSpaces(string name)
        {
            return name.Replace(" ", "");
        }
    }
}