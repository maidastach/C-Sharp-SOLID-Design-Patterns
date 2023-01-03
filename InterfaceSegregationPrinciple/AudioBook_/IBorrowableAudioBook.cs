using InterfaceSegregationPrinciple.GeneralInterfaces;

namespace InterfaceSegregationPrinciple.AudioBook_
{
    internal interface IBorrowableAudioBook : IBorrowable, IAudioBook
    {
    }
}
