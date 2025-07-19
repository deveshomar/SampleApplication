using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApplication
{
    //interview Questions
    public class parentClass
    {
        protected void GetProctedMethod()
        {
            Console.WriteLine("Inside parentClass->GetProctedMethod");
        }
        public void GetpublicMethod_parentClass()
        {
            Console.WriteLine("Inside parentClass->GetpublicMethod_parentClass");
        }
    }
    public class ChildClass:parentClass
    {
        public void GetpublicMethod_ChildClass()
        {
            Console.WriteLine("Inside ChildClass->GetpublicMethod_ChildClass");
            GetProctedMethod();

        }


    }

    //  ChildClass obj = new ChildClass();
    // obj.GetpublicMethod_ChildClass();

    // proteched meber can access in child class but not outside that class
   // obj.GetProctedMethod();  // will show error due to protection level
    public class Account
    {
        protected decimal balance;

        public void Deposit(decimal amount)
        {
            UpdateBalance(amount);
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= balance)
            {
                UpdateBalance(-amount);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        // This method is protected: only this class and derived classes can use it.
        protected void UpdateBalance(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"Balance updated. New balance: {balance}");
        }
    }

    public class SavingsAccount : Account
    {
        public void AddMonthlyInterest()
        {
            decimal interest = balance * 0.03m;  // 3% interest
            UpdateBalance(interest);  // We can access this protected method here!
        }
    }

    /*
                * UpdateBalance() is an internal method for maintaining balance.

                It’s not exposed to outside classes (e.g., Program, Main, or other systems), so it prevents misuse.

                But it’s still accessible to SavingsAccount and other subclasses — which makes it reusable and extendable.
     
                SavingsAccount savings = new SavingsAccount();

                // Perform operations
                savings.Deposit(1000);              // Deposit 1000
                savings.AddMonthlyInterest();       // Add 3% interest
                savings.Withdraw(200);              // Withdraw 200

                // Uncommenting the below line will cause a compilation error:
                // savings.UpdateBalance(500);     ❌ Not allowed (protected method)
     
                // OUT
                Balance updated. New balance: 1000
                Balance updated. New balance: 1030
                Balance updated. New balance: 830


                Deposit(1000) is public → calls UpdateBalance(1000)

                AddMonthlyInterest() (only in subclass) → calls UpdateBalance(30)

                Withdraw(200) → calls UpdateBalance(-200)

                UpdateBalance(...) is protected, so it can't be called like this:
     
     */
}
