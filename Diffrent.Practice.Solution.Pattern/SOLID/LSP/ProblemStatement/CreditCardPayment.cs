using Diffrent.Practice.Solution.Pattern.SOLID.LSP.ProblemStatement.Abstraction;

namespace Diffrent.Practice.Solution.Pattern.SOLID.LSP.ProblemStatement
{
    public class CreditCardPayment : PaymentService
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Credit Card Payment Processed");
        }
    }
}
