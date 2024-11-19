using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
        public class Bankaccount
        {
            // Private field: we hide this field from direct access
            private double balance;

            // Public property to access the balance
            public double Balance
            {
                get { return balance; }
                private set { balance = value; }  // We don't want the balance to be set directly from outside
            }

            // Constructor to initialize a new bank account with an initial balance
            public Bankaccount(double initialBalance)
            {
                if (initialBalance < 0)
                {
                    Console.WriteLine("Initial balance cannot be negative!");
                }
                else
                {
                    balance = initialBalance;
                }
            }

            // Method to deposit money into the account
            public void Deposit(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Deposit amount must be positive!");
                }
                else
                {
                    balance += amount;
                    Console.WriteLine($"Deposited {amount}. New balance: {balance}");
                }
            }

            // Method to withdraw money from the account
            public void Withdraw(double amount)
            {
                if (amount <= 0)
                {
                    Console.WriteLine("Withdrawal amount must be positive!");
                }
                else if (amount > balance)
                {
                    Console.WriteLine("Insufficient balance!");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrew {amount}. New balance: {balance}");
                }
            }
        }

        public class Encapsultion
        {
            public void Run()
            {
                // Creating a new bank account with an initial balance of 1000
                Bankaccount account = new Bankaccount(1000);
                // Checking the balance (can access the balance but can't modify directly)
                Console.WriteLine("Current balance: " + account.Balance);  // Output: 1000
                                                                           // Depositing money
                account.Deposit(500);  // Output: Deposited 500. New balance: 1500
                                       // Trying to withdraw more than the balance
                account.Withdraw(2000);  // Output: Insufficient balance!
                                         // Withdrawing a valid amount
                account.Withdraw(300);  // Output: Withdrew 300. New balance: 1200
                                        // Trying to access or modify balance directly (this is not allowed!)
                                        // account.balance = 5000;  // Compile-time error: 'balance' is inaccessible due to its protection level
            }
        }

    }
