using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.cs
{
   public class Program
    {
        static void Main(string[] args)
        {

            var prebook = new PreBook();
            var payarrive = new PayArrive();
            


            prebook.PreBookNumbers(); //Input number of passengers that prebooked tickets.
            payarrive.ArrivalNumbers();







        }
    }
}
