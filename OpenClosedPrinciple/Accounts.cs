namespace OpenClosedPrinciple
{
    internal class Accounts
    {
        public EmployeeModel Create(PersonModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.Email = $"{ person.FirstName.Substring(0, 1) }{ person.LastName }@test.au";
            
            return output;
        }
    }
}