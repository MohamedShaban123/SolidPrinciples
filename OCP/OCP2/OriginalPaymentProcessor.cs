using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OCP2
{
    internal class OriginalPaymentProcessor
    {
        public void ProcessPayment(string method, double amount)
        {
            if (method == "CreditCard")
            {
                Console.WriteLine($"Processing Credit Card payment of {amount}");
            }
            else if (method == "PayPal")
            {
                Console.WriteLine($"Processing PayPal payment of {amount}");
            }
            else
            {
                Console.WriteLine("Invalid payment method");
            }
        }
    }
}
