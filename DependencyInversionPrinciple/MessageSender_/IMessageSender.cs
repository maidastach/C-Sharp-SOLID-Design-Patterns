using DependencyInversionPrinciple.Person_;

namespace DependencyInversionPrinciple.MessageSender_
{
    internal interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}