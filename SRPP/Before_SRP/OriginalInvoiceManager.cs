using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class OriginalInvoiceManager
    {
        public void AddInvoice(string invoiceDetails)
        {
            // Add invoice logic
            Console.WriteLine("Invoice added: " + invoiceDetails);
            // Save to database
            Console.WriteLine("Invoice saved to database");
            // Send confirmation email
            Console.WriteLine("Email sent to customer");
        }
    }
}
