using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.Before_DIP
{
    internal class UserService
    {
        public EmailService email = new EmailService();
        public void sendemail(string to ,string from)
        {
            email.sendemail(to,from);
        }
    }
}
