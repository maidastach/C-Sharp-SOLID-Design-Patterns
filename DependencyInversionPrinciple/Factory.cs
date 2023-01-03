using DependencyInversionPrinciple.Chore_;
using DependencyInversionPrinciple.Logger_;
using DependencyInversionPrinciple.MessageSender_;
using DependencyInversionPrinciple.Person_;

namespace DependencyInversionPrinciple
{
    internal static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateMessageSender());
        }
        public static IMessageSender CreateMessageSender()
        {
            // Changing this to new Emailer() does not break the application
            return new Texter();
        }
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
