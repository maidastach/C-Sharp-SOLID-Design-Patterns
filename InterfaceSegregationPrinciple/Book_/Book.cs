namespace InterfaceSegregationPrinciple.Book_
{
    internal class Book : IBorrowableBook
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int CheckOutDurationInDays { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowerDate { get; set; }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowerDate = DateTime.Now;
        }
        public void CheckIn()
        {
            Borrower = "";
        }
        public DateTime GetDueDate()
        {
            return BorrowerDate.AddDays(CheckOutDurationInDays);
        }
    }
}