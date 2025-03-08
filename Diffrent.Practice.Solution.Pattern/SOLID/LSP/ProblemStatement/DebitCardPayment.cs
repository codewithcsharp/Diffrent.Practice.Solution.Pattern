using Diffrent.Practice.Solution.Pattern.SOLID.LSP.ProblemStatement.Abstraction;

namespace Diffrent.Practice.Solution.Pattern.SOLID.LSP.ProblemStatement
{
    public class DebitCardPayment : PaymentService
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Debit Card Payment Processed");
        }
    }
}
