using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_OOP_Exercise.BankModule
{
    //Class
    public class BankAccount
    {
        public string Owner { get; }
        public decimal Balance { get; private set; }

        //Constructor to initialize account with validation
        public BankAccount(string owner, decimal initialBalance)
        {
            Owner = owner;
            Balance = initialBalance > 0 ? initialBalance : 0; //Validation for non-negative initial balance
        }

        // Method to deposit money into the account with validation
        public void Deposit(decimal amount)
                {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount should be positive.");
            }
            Balance += amount;
            Console.WriteLine($"Deposited amount R{amount}. New balance: R{Balance}");
        }

        //Method to withdraw money from the account with validation
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount should be positive.");
                return;
            }
            if (amount > Balance)
            {
                Console.WriteLine ("Insufficient funds for this withdrawal.");
                return;
            }
            Balance -= amount;
            Console.WriteLine($"Withdrew amount R{amount}. New balance: R{Balance}");
        }
    }
}
