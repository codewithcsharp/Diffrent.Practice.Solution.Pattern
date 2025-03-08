using Diffrent.Practice.Solution.Pattern.SOLID.LSP.SolutionStatement.Interfaces;

namespace Diffrent.Practice.Solution.Pattern.SOLID.LSP.SolutionStatement
{
    public class PaymentProcessor
    {
        private ICreditCardPaymentService _creditCardPaymentService;
        private IDebitCardPaymentService _debitCardPaymentService;
        private IUpiPaymentService _upiPaymentService;

        public PaymentProcessor(ICreditCardPaymentService creditCardPaymentService, IDebitCardPaymentService debitCardPaymentService, IUpiPaymentService upiPaymentService)
        {
            _creditCardPaymentService = creditCardPaymentService;
            _debitCardPaymentService = debitCardPaymentService;
            _upiPaymentService = upiPaymentService;
        }

        public void ProcessCreditCardPayment(int amount)
        {
            _creditCardPaymentService.ProcessCreditCardPayment($"Your transaction of {amount} has been completed", amount);
        }

        public void ProcessDebitCardPayment(int amount)
        {
            _debitCardPaymentService.ProcessDebitCardPayment($"Your transaction of {amount} has been completed", amount);
        }

        public void ProcessUpiPayment(int amount)
        {
            _upiPaymentService.ProcessUpiPayment($"Your transaction of {amount} has been completed", amount);
        }
    }
}
