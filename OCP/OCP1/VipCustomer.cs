using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OCP1
{
    internal class VipCustomer : IApplyDiscount
    {
        public double GetDiscount(double amount)
        {
            return amount * 0.3; // 10% discount
        }
    }
}
