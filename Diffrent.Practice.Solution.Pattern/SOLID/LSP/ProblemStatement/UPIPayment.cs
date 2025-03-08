using Diffrent.Practice.Solution.Pattern.SOLID.LSP.ProblemStatement.Abstraction;

namespace Diffrent.Practice.Solution.Pattern.SOLID.LSP.ProblemStatement
{
    public class UPIPayment : PaymentService
    {
        public override void ProcessPayment()
        {
            throw new PlatformNotSupportedException("UPI Payment Not Supported");
        }
    }
}
