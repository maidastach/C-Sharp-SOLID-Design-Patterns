using InterfaceSegregationPrinciple.GeneralInterfaces;

namespace InterfaceSegregationPrinciple.Book_
{
    internal interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}