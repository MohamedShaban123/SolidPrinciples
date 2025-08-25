using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OCP2
{
    internal interface IPayment
    {
        public void paymentProcess(double amount);
    }
}
