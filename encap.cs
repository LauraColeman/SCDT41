using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation.cs
{
    public class GetCost
    {
        private double Length;
        private double Width;

        public void InputDetails() //access private through method
        {
            
            Console.WriteLine("Input Garden length"); //length of garden
            Length = Convert.ToDouble(Console.ReadLine()); //cast
            Console.WriteLine("Input Garden width"); //width of garden
            Width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total cost is {0}", Calculate());
        }


        Double Calculate()  //still in private class
        {
            double total;

            total = (Length * Width) * 2.1; //BIDMASS

            return total; //returns total of above

        }
    }
    class encap
    {
    }
}
