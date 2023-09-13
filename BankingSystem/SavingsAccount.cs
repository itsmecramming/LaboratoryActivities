namespace BankingSystem
{
    public class SavingsAccount : Account
    {
        private double interestRate;

        public double InterestRate
        {
            get { return interestRate; }
        }

        public SavingsAccount(int accountNumber, double interestRate) : base(accountNumber)
        {
            this.interestRate = interestRate;
        }

        public void CalculateInterest()
        {
            double interest = Balance * interestRate / 100;
            Deposit(interest);
            Console.WriteLine($"Interest Earned: ${interest}");
        }
    }
}