using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.cs
{
       class CurrentAccount : BankAccount
    {


        public Branch branch;

        public CurrentAccount(int accountNumber, double balance, Branch branch): base(accountNumber, balance)
        {
            
        }


        public double CalculateCharges()
        {
            return UpdateBalance();
        }

        
          public double CalculateInterest()
        {
            return ReturnBalance() * 0.12;
        }


    }
    }


    


