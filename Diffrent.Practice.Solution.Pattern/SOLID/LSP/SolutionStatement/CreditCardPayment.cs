using Diffrent.Practice.Solution.Pattern.SOLID.LSP.SolutionStatement.Interfaces;

namespace Diffrent.Practice.Solution.Pattern.SOLID.LSP.SolutionStatement
{
    public class CreditCardPayment : ICreditCardPaymentService
    {
        public void ProcessCreditCardPayment(string message, int amount)
        {
            Console.WriteLine($"Payment Processed via Credit Card  : {message}");
        }
    }
}
