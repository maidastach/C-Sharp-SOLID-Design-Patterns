namespace LiskovSubstitutionPrinciple
{
    internal interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}