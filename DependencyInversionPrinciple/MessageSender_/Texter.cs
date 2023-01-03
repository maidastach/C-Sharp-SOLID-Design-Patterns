using DependencyInversionPrinciple.Person_;

namespace DependencyInversionPrinciple.MessageSender_
{
    internal class Texter : IMessageSender
    {
        public void SendMessage(IPerson person, string message)
        {
            Console.WriteLine($"I am texting {person.FirstName} to say: {message}");
        }
    }
}
