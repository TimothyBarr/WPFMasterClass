using CSharpPartice.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPartice.Classes
{
     public class BankAccount : IInformation 
    {
        private double balance;
        public double Balance
        {
            get
            {
                if (balance < 1000000)
                    return balance;
                return 1000000;
            }

            protected set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        //constructor
        public BankAccount() => Balance = 100;

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        public virtual double AddToBalance(double balaceToBeAdded)
        {
            Balance += balaceToBeAdded;
            return Balance;
        }

        public string GetInformation()
        {
            //   return $"Your current balance is: {Balance:c}";
            return $"Your current balance is: {Balance:c}";
//            return $"Your bankAccount is: {Balance:c}";
        }
    }

    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            Balance = 10;
        }

        public override double AddToBalance(double balaceToBeAdded)
        {
            if (balaceToBeAdded > 1000)
                balaceToBeAdded = 1000;
            if (balaceToBeAdded < -1000)
                balaceToBeAdded = -1000;

            return base.AddToBalance(balaceToBeAdded);
        }

        public string GetInformation()
        {
            return $"Your current balance is: {Balance:c}";
//            return $"Your childAccount is: {Balance:c}";
        }

        
    }


}
