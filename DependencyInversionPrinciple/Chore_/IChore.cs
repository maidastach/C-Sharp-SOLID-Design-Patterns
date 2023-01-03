using DependencyInversionPrinciple.Person_;

namespace DependencyInversionPrinciple.Chore_
{
    internal interface IChore
    {
        string ChoreName { get; set; }
        double HoursWorked { get; set; }
        bool IsComplete { get; }
        IPerson Owner { get; set; }

        void CompleteChore();
        void PerformedWork(double hours);
    }
}