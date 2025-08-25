using DIP.After_DIP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Before_DIP
{
    internal class EmailService : IMessage
    {
        public void sendemail(string to, string from)
        {
            Console.WriteLine($"This message from {from} to {to}");
        }
    }
}
