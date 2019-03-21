using System;

namespace Mediator
{
    public abstract class IUser
    {
        protected IChat _chat;
        protected String _name;
        protected bool _isEnable = true;

        public bool isEnable()
        {
            return _isEnable;
        }

        public void setEnable(bool isEnable)
        {
            _isEnable = isEnable;
        }

        public IUser(IChat chat, string name)
        {
            _chat = chat;
            _name = name;
        }

        public string getName()
        {
            return _name;

        }

        public void sendMessage(string message)
        {
            _chat.sendMessage(message,this);
        }

        public abstract void getMessage(string message);

        public string ToString()
        {
            return "User [name=" + _name + "]";
        }
    }
}