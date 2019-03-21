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
            
            IUser admin = new Admin(chat, "Иван Иваныч");
            IUser user1 = new SimpleUser(chat,"Sergey");
            IUser user2 = new SimpleUser(chat, "Dasha");
            IUser user3 = new SimpleUser(chat, "Masha");
            user2.setEnable(false);

            chat.setAdmin(admin);
            chat.addUser(user1);
            chat.addUser(user2);
            chat.addUser(user3);

            user1.sendMessage("Hello, I'm user");
            admin.sendMessage("Admin online!!!");
        }
    }
}
