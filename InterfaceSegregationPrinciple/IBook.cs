namespace InterfaceSegregationPrinciple
{
    internal interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}