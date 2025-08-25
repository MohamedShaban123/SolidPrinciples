using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.OCP1
{
    internal class OriginalDiscountService
    {


        public double GetDiscount(string customerType, double amount)
        {
            if (customerType == "Regular")
                return amount * 0.1; // 10% discount
            else if (customerType == "Premium")
                return amount * 0.2; // 20% discount
            else
                return 0; // No discount
        }



    }
}
