namespace Diffrent.Practice.Solution.Pattern.DesignPatterns.BuilderDesignPattern
{
    public class BankAccount
    {
        public string AccountHolderName { get; set; } = default!;
        public string AccountType { get; set; } = default!;
        public double Balance { get; set; }
        public double InterestRate { get; set; }
        public bool IsOverdraftEnabled { get; set; }

        public override string ToString()
        {
            return $"Account Holder: {AccountHolderName}\n" +
                   $"Account Type: {AccountType}\n" +
                   $"Balance: {Balance:C}\n" +
                   $"Interest Rate: {InterestRate}%\n" +
                   $"Overdraft Enabled: {IsOverdraftEnabled}\n";
        }
    }

}
