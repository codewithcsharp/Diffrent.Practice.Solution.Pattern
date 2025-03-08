using Diffrent.Practice.Solution.Pattern.SOLID.LSP.SolutionStatement.Interfaces;

namespace Diffrent.Practice.Solution.Pattern.SOLID.LSP.SolutionStatement
{
    public class DebitCardPayment : IDebitCardPaymentService
    {
        public void ProcessDebitCardPayment(string message, int amount)
        {
            Console.WriteLine($"Payment Processed via Debit Card  : {message}");
        }
    }
}
