namespace InterfaceSegregationPrinciple.GeneralInterfaces
{
    internal interface IBorrowable
    {
        int CheckOutDurationInDays { get; set; }
        string Borrower { get; set; }
        DateTime BorrowerDate { get; set; }

        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}