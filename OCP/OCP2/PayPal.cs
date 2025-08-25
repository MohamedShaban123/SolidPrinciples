using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OCP2
{
    internal class PayPal : IPayment
    {
        public void paymentProcess(double amount)
        {
            Console.WriteLine($"Processing PayPal payment of {amount}");
        }
    }
}
