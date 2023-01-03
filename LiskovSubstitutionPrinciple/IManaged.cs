namespace LiskovSubstitutionPrinciple
{
    internal interface IManaged
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);

    }
}
