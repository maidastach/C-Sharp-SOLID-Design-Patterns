namespace InterfaceSegregationPrinciple
{
    internal interface ILibraryItem
    {
        string Author { get; set; }
        DateTime BorrowerDate { get; set; }
        string Borrower { get; set; }
        int CheckOutDurationInDays { get; set; }
        string LibraryId { get; set; }
        int Pages { get; set; }
        string Title { get; set; }

        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}