using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.cs
{
     class BankAccount 
    {
       

        private int accountNumber;
        private double balance;
       

        public BankAccount(int accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.balance = balance;

        }


        public double UpdateBalance()
        {
            return balance;
        }
                        
        public double ReturnBalance()
        {
            return balance;
        }


        
    }
}
