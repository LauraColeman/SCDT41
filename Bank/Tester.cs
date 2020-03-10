using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.cs
{
    class Tester
    {
        public Tester()
        {

            var JimShaun = new Customer("Jim", "Taunton", new CurrentAccount(123, 10000, new Branch("Taunton")));

            JimShaun.ShowDetails();
        }
    }
}