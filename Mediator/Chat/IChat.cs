namespace Mediator
{
    public interface IChat
    {
        void sendMessage(string message, IUser user);
    }
}