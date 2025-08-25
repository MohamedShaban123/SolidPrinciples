using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OCP2
{
    internal class PaymentServiceProcessor
    {
        private readonly IPayment _payment;

        public PaymentServiceProcessor(IPayment payment)
        {
            _payment = payment;
        }

        public void paymentprcess(double amount)
        {
            _payment.paymentProcess(amount);
        }
    }
}
