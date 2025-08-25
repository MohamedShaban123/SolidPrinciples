using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.After_DIP
{
    internal class UserService : IMessage
    {
        private readonly IMessage _message;

        public UserService( IMessage message)
        {
            this._message = message;
        }


        public void sendemail(string to, string from)
        {
            _message.sendemail(to, from);
        }
    }
}
