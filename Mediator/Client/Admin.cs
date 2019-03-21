using System;

namespace Mediator
{
    public class Admin : IUser
    {
        private IChat _chat;

        public Admin(IChat chat)
        {
            _chat = chat;
        }

        public void getMessage(string message)
        {
            Console.WriteLine("Администратор получает сообщение '" + message + "'");
        }

        public void sendMessage(string message)
        {
            _chat.sendMessage(message, this);
        }
    }
}