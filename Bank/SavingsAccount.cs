using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.cs
{
    class SavingsAccount : BankAccount
    {

        public Branch branch;

        public SavingsAccount(int accountNumber, double balance, Branch branch): base(accountNumber ,balance)
        {

        }





        public double CalculateCharges()
        {
            return UpdateBalance();
        }
        public double calculateInterest()
        {
            return ReturnBalance() * 0.12;
        }



                
    }
}
