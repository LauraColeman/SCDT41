using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.cs
{
    class Customer
    {
        private string Name;
        private string Address;
        private CurrentAccount myAccount; //Giving customer an account.



        public Customer(string name, string address, CurrentAccount account)
        {
            this.Name = name;
            this.Address = address;
            this.myAccount = account;
            
        }
        

        public void ShowDetails()
        {
            Console.WriteLine("Customer Name {0}", Name);
            Console.WriteLine("Customer Address {0}", Address);
            Console.WriteLine("Customer Balance £{0}", myAccount.ReturnBalance());
            

        }


    }
}
