using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.cs
{
    public class PayArrive
    {
        public void ArrivalNumbers()
        {

            List<int> intList1 = new List<int>();


            Console.WriteLine("Enter the number of passengers who have paid on arrival for coach A:");
            int coachA = Convert.ToInt32(Console.ReadLine());
            intList1.Add(coachA);


            Console.WriteLine("Enter the number of passengers who have paid on arrival for coach B:");
            int coachB = Convert.ToInt32(Console.ReadLine());
            intList1.Add(coachB);

            Console.WriteLine("Enter the number of passengers who have paid on arrival for coach C:");
            int coachC = Convert.ToInt32(Console.ReadLine());
            intList1.Add(coachC);

            Console.WriteLine("Enter the number of passengers who have paid on arrival for coach D:");
            int coachD = Convert.ToInt32(Console.ReadLine());
            intList1.Add(coachD);

            Console.WriteLine("The total number of passengers that have pre-booked is {0}.", coachA + coachB + coachC + coachD); //Totals values of user input
            
        }
    }
}