namespace SingleResponsibilityPrinciple.Person_
{
    internal class PersonFetcherData
    {
        public static Person FetchData()
        {
            Person user = new Person();

            Console.Write("What is your first name: ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name: ");
            user.LastName = Console.ReadLine();

            return user;
        }
    }
}