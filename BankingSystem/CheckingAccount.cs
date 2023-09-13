namespace BankingSystem
{
    public class CheckingAccount : Account
    {
        private double overdraftLimit;

        public double OverdraftLimit
        {
            get { return overdraftLimit; }
        }

        public CheckingAccount(int accountNumber, double overdraftLimit) : base(accountNumber)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Withdraw(double amount)
        {
            if (Balance - amount >= -overdraftLimit)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine($"Withdrawal amount exceeds overdraft limit in Account {AccountNumber}");
            }
        }
    }
}
