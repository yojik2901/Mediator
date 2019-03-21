using System;

namespace Mediator
{
    public class Admin : IUser
    {
        public Admin(IChat chat, string name)
            : base(chat, name)
        {}

        public override void getMessage(string message)
        {
            Console.WriteLine("Администратор " + getName() + " получает сообщение '" + message + "'");
        }
    }
}