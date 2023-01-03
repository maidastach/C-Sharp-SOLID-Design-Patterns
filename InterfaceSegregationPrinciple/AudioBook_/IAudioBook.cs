using InterfaceSegregationPrinciple.GeneralInterfaces;

namespace InterfaceSegregationPrinciple.AudioBook_
{
    internal interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}