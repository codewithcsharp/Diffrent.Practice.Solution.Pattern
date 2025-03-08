namespace Diffrent.Practice.Solution.Pattern.DesignPatterns.BuilderDesignPattern.Interfaces
{
    public interface IBankAccountBuilder
    {
        IBankAccountBuilder SetAccountHolderName(string name);
        IBankAccountBuilder SetAccountType(string type);
        IBankAccountBuilder SetBalance(double amount);
        IBankAccountBuilder SetInterestRate(double rate);
        IBankAccountBuilder EnableOverdraft(bool enable);
        BankAccount Build();
    }

}
