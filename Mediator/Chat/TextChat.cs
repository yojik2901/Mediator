using System;
using System.Collections;
using System.Collections.Generic;

namespace Mediator
{
    public class TextChat : IChat
    {
        private IUser _admin;
        private List<IUser> _users = new List<IUser>();

        public void setAdmin(IUser admin)
        {
            _admin = admin;
        }

        public void addUser(IUser user)
        {
            _users.Add(user);
        }
        
        public void sendMessage(string message, IUser user)
        {
            for (int i = 0; i < _users.Count; i++)
            {
                _users[i].getMessage(message);
            }
            _admin.getMessage(message);
        }
    }
}