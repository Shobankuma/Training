using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingExcercise
{
    // Base class
    class BankAccount
    {
        // Virtual method to allow overriding in derived classes
        public virtual void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a general bank account.");
        }
    }

    // Derived class 1: SavingsAccount
    class SavingsAccount : BankAccount
    {
        // Overriding the base class method to provide specific implementation
        public override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a savings account at 5% interest rate.");
        }
    }

    // Derived class 2: CurrentAccount
    class CurrentAccount : BankAccount
    {
        // Overriding the base class method to provide specific implementation
        public override void CalculateInterest()
        {
            Console.WriteLine("Calculating interest for a current account at 2% interest rate.");
        }
    }

    class MethodOveriding
    {
        public void Run()
        {
            // Create objects of both SavingsAccount and CurrentAccount
            SavingsAccount savings = new SavingsAccount();
            CurrentAccount current = new CurrentAccount();

            // Calling the overridden methods using base class reference
            savings.CalculateInterest();  // Calls overridden method in SavingsAccount
            current.CalculateInterest();  // Calls overridden method in CurrentAccount
        }
    }

}
