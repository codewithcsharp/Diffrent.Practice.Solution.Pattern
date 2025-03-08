namespace Diffrent.Practice.Solution.Pattern.SOLID.SRP.SolutionStatement
{
    public class InvoiceManager
    {
        private readonly InvoiceProcessor _invoiceProcessor;
        private readonly InvoicePrinter _invoicePrinter;
        private readonly InvoiceRepository _invoiceRepository;

        public InvoiceManager(InvoiceProcessor invoiceProcessor, InvoicePrinter invoicePrinter, InvoiceRepository invoiceRepository)
        {
            _invoiceProcessor = invoiceProcessor;
            _invoicePrinter = invoicePrinter;
            _invoiceRepository = invoiceRepository;
        }

        public void CalculateInvoice()
        {
            _invoiceProcessor.CalculateInvoice();
        }

        public void PrintInvoice()
        {
            _invoicePrinter.PrintInvoice();
        }

        public void SaveInvoice()
        {
            _invoiceRepository.SaveInvoice();
        }
    }
}
