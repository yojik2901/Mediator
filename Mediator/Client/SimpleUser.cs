using System;

namespace Mediator
{
    public class SimpleUser : IUser
    {
        private IChat _chat;

        public SimpleUser(IChat chat)
        {
            _chat = chat;
        }

        public void getMessage(string message)
        {
            Console.WriteLine("Пользователь получает сообщение '" + message + "'");
        }

        public void sendMessage(string message)
        {
            _chat.sendMessage(message, this);
        }
    }
}