using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            TextChat chat = new TextChat();
            
            IUser admin = new Admin(chat);
            IUser user1 = new SimpleUser(chat);
            IUser user2 = new SimpleUser(chat);

            chat.setAdmin(admin);
            chat.addUser(user1);
            chat.addUser(user2);

            user1.sendMessage("Hello, I'm user");
            admin.sendMessage("Admin online!!!");
        }
    }
}
