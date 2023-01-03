namespace SingleResponsibilityPrinciple.Person_
{
    internal class PersonValidation
    {
        public static bool Validate(Person user)
        {
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                StandardMessages.ValidationError("first name");
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                StandardMessages.ValidationError("last name");
                return false;
            }

            return true;
        }

    }
}