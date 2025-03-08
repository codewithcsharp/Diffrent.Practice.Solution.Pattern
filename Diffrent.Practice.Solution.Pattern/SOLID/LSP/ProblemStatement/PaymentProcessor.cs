using Diffrent.Practice.Solution.Pattern.SOLID.LSP.ProblemStatement.Abstraction;

namespace Diffrent.Practice.Solution.Pattern.SOLID.LSP.ProblemStatement
{
    public class PaymentProcessor
    {
        public void ProcessPayment(PaymentService paymentService)
        {
            paymentService.ProcessPayment();
        }
    }
}
