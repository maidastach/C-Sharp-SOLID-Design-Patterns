using InterfaceSegregationPrinciple.GeneralInterfaces;

namespace InterfaceSegregationPrinciple.DVD_
{
    internal interface IDVD : ILibraryItem
    {
        List<string> Actors { get; set; }
        int RuntimeInMinutes { get; set; }

    }
}