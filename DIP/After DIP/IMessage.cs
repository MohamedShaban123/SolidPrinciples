using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.After_DIP
{
    internal interface IMessage
    {
        public void sendemail(string to, string from); 
    }
}
