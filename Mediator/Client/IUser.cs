namespace Mediator
{
    public interface IUser
    {
        void sendMessage(string message);
        void getMessage(string message);
    }
}