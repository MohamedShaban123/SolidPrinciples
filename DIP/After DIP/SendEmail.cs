using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.After_DIP
{
    internal class SendEmail : IMessage
    {
        public void sendemail(string to, string from)
        {
            Console.WriteLine($"This message from {from} to {to}");
        }
    }
}
