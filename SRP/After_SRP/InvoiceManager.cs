using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.After_SRP
{
    internal class InvoiceManager
    {
        private readonly Email _email;
        private readonly InvoiceRepository _invoiceRepository;

        public InvoiceManager(Email email,InvoiceRepository invoiceRepository)
        {
            this._email = email;
            this._invoiceRepository = invoiceRepository;
        }


        public void AddInvoice(string invoiceDetails)
        {
            // Add invoice logic
            Console.WriteLine("Invoice added: " + invoiceDetails);
            // Add logic to add save Invoice to Db
            _invoiceRepository.SaveInvoiceToDb();
            // Add logic to send email
            _email.SendEmail();
        }
    }
}
