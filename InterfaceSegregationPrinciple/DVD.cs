﻿namespace InterfaceSegregationPrinciple
{
    internal class DVD : ILibraryItem
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; } = "";
        public int Pages { get; set; } = -1;
        public int CheckOutDurationInDays { get; set; } = 14;
        public string Borrower { get; set; }
        public DateTime BorrowerDate { get; set; }
        public List<string> Actors { get; set; }
        public int RuntimeInMinutes { get; set; }

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