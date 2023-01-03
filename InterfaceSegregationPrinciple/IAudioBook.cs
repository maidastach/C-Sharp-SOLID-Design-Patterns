namespace InterfaceSegregationPrinciple
{
    internal interface IAudioBook : ILibraryItem
    {
        int RuntimeInMinutes { get; set; }
    }
}