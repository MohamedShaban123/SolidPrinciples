namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before SRP
            //SRP.Before_SRP.OriginalInvoiceManager InvoiceManager = new Before_SRP.OriginalInvoiceManager();
            //InvoiceManager.AddInvoice("invoice add successfully to Db");
            #endregion
            #region After SRP
            //SRP.After_SRP.InvoiceManager invoiceManager = new After_SRP.InvoiceManager(new After_SRP.Email(), new After_SRP.InvoiceRepository());
            //invoiceManager.AddInvoice("invoice add successfully to Db");
            #endregion
        }
    }
}
