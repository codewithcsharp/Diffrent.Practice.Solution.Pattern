using Diffrent.Practice.Solution.Pattern.DesignPatterns.BuilderDesignPattern.Interfaces;

namespace Diffrent.Practice.Solution.Pattern.DesignPatterns.BuilderDesignPattern
{
    public class BankAccountDirector
    {
        public BankAccount BuildSavingsAccount(IBankAccountBuilder builder)
        {
            return builder.SetAccountHolderName("John Doe")
                          .SetAccountType("Savings")
                          .SetBalance(5000)
                          .SetInterestRate(4.5)
                          .EnableOverdraft(false)
                          .Build();
        }

        public BankAccount BuildCurrentAccount(IBankAccountBuilder builder)
        {
            return builder.SetAccountHolderName("Jane Smith")
                          .SetAccountType("Current")
                          .SetBalance(10000)
                          .SetInterestRate(2.0)
                          .EnableOverdraft(true)
                          .Build();
        }
    }

}
