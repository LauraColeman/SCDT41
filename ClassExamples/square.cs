using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation.cs
{
    public class Square
    {
        public double length;  
        public double width;  

        public void Calculate() // calculate method
        {
            double total;  //stores total size
            double totalCost;  //stores final cost
            total = length + width;  //calculates size
            totalCost = total * 2.10; //calculates cost £2.10 per sq.metre
            Console.WriteLine("Total cost is :£{0}", totalCost);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square();  //object
            Console.WriteLine("Input Length"); 
            square.length = Convert.ToDouble(Console.ReadLine()); //cast 
            Console.WriteLine("Input width");
            square.length = Convert.ToDouble(Console.ReadLine()); 

            square.Calculate();

            
           }
    }
}
