using System;

namespace Mediator
{
    public class SimpleUser : IUser
    {
        public SimpleUser(IChat chat, string name)
            : base(chat, name)
        { }

        public override void getMessage(string message)
        {
            Console.WriteLine("Пользователь "+ getName() + " получает сообщение '" + message + "'");
        }
    }
}