using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OCP1
{
    internal class RegularCustomer : IApplyDiscount
    {
        public double GetDiscount(double amount)
        {
            return amount * 0.1; // 10% discount
        }
    }
}
