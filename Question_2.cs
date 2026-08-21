using System;

namespace Dotnet_Assignment_3
{
    class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public BankAccount(string accountNumber, string holderName, double balance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Amount deposited successfully");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid withdrawal amount");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Amount withdrawn successfully");
            }
        }

        public void Display()
        {
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Holder Name: " + holderName);
            Console.WriteLine("Balance: " + balance);
        }
    }

    class Que_2
    {
        static void Main()
        {
            BankAccount account = new BankAccount("MCA01", "Abhishek Kumar", 10000);

            account.Display();
            account.Deposit(5000);
            account.Withdraw(3000);
            account.Display();
        }
    }
}
