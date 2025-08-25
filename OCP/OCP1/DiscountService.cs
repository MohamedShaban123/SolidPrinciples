using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OCP1
{
    internal class DiscountService
    {
        private readonly IApplyDiscount _applyDiscount;

        public DiscountService( IApplyDiscount applyDiscount)
        {
            _applyDiscount = applyDiscount;
        }

        public double ApplyDiscount(double amount)
        {
           return _applyDiscount.GetDiscount(amount);
        }
    }
}
