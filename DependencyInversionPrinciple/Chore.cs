﻿namespace DependencyInversionPrinciple
{
    internal class Chore
    {
        public string ChoreName { get; set; }
        public Person Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; private set; }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            
            Logger log = new Logger();
            log.Log($"Performed work on { ChoreName }");
        }
        public void CompleteChore()
        { 
            IsComplete = true;

            Logger log = new Logger();
            log.Log($"Completed { ChoreName }");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The chore { ChoreName } is complete.");
        }
    }
}