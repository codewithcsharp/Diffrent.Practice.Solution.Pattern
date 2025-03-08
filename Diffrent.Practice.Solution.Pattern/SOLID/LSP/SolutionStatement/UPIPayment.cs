using Diffrent.Practice.Solution.Pattern.SOLID.LSP.SolutionStatement.Interfaces;

namespace Diffrent.Practice.Solution.Pattern.SOLID.LSP.SolutionStatement
{
    public class UPIPayment : IUpiPaymentService
    {
        public void ProcessUpiPayment(string message, int amount)
        {
            Console.WriteLine($"Payment Processed via Upi  : {message}");
        }
    }
}
