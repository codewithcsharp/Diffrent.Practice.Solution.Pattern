using Diffrent.Practice.Solution.Pattern.DesignPatterns.BuilderDesignPattern.Interfaces;

namespace Diffrent.Practice.Solution.Pattern.DesignPatterns.BuilderDesignPattern
{
    public class BankAccountBuilder : IBankAccountBuilder
    {
        private readonly BankAccount _bankAccount = new BankAccount();

        public IBankAccountBuilder SetAccountHolderName(string name)
        {
            _bankAccount.AccountHolderName = name;
            return this;
        }

        public IBankAccountBuilder SetAccountType(string type)
        {
            _bankAccount.AccountType = type;
            return this;
        }

        public IBankAccountBuilder SetBalance(double amount)
        {
            _bankAccount.Balance = amount;
            return this;
        }

        public IBankAccountBuilder SetInterestRate(double rate)
        {
            _bankAccount.InterestRate = rate;
            return this;
        }

        public IBankAccountBuilder EnableOverdraft(bool enable)
        {
            _bankAccount.IsOverdraftEnabled = enable;
            return this;
        }

        public BankAccount Build()
        {
            return _bankAccount;
        }
    }
}
