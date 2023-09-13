using System;

namespace BankingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount(0806, 3.0);
            CheckingAccount checkingAccount = new CheckingAccount(0710, 500.0);

            savingsAccount.Deposit(1500);
            Console.WriteLine($"Account Number: {savingsAccount.AccountNumber}");
            Console.WriteLine($"Balance: ${savingsAccount.Balance:F2}");
            savingsAccount.CalculateInterest();
            Console.WriteLine($"Account Number: {savingsAccount.AccountNumber}");
            Console.WriteLine($"Balance: ${savingsAccount.Balance:F2}");

            Console.WriteLine();

            checkingAccount.Deposit(1500);
            Console.WriteLine($"Account Number: {checkingAccount.AccountNumber}");
            Console.WriteLine($"Balance: ${checkingAccount.Balance:F2}");
            checkingAccount.Withdraw(1500);
            Console.WriteLine($"Account Number: {checkingAccount.AccountNumber}");
            Console.WriteLine($"Balance: ${checkingAccount.Balance:F2}");

            Console.ReadLine();
        }
    }
}
