using System;

namespace BankingSystem
{
    public abstract class Account
    {
        private int accountNumber;
        private double balance;

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public Account(int accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        public virtual void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited ${amount} into Account {accountNumber}");
        }

        public virtual void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn ${amount} from Account {accountNumber}");
            }
            else
            {
                Console.WriteLine($"Insufficient funds in Account {accountNumber}");
            }
        }
    }
}
