using InterfaceSegregationPrinciple.GeneralInterfaces;

namespace InterfaceSegregationPrinciple.Book_
{
    internal interface IBorrowableBook : IBorrowable, IBook
    {
    }
}
