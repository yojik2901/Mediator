using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Mediator
{
    public class TextChat : IChat
    {
        private IUser _admin;
        private List<IUser> _users = new List<IUser>();

        public void setAdmin(IUser admin)
        {
            if(_admin == null && admin is Admin)
                _admin = admin;
            else
            {
                throw new Exception("Не хватает прав");
            }
        }

        public void addUser(IUser user)
        { 
            if(_admin == null)
                throw new Exception("Вчате нет админа");

            if (user is SimpleUser)
                _users.Add(user);
            else
                throw new Exception("Админ не может входить в другой чат!");
        }
        
        public void sendMessage(string message, IUser user)
        {
            if (user is Admin)
            {
                foreach (var u in _users)
                {
                    u.getMessage(user.getName() + ": " + message);
                }
            }

            if (user is SimpleUser)
            {
                foreach (var u in _users)
                {
                    if(u!=user && u.isEnable())
                        u.getMessage(user.getName() + ": " + message);
                }
                if(_admin.isEnable())
                    _admin.getMessage(user.getName() + ": " + message);
            }
        }
    }
}