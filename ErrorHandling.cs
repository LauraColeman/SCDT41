using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errorhandling.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            try //problem code in try
            {
                Console.WriteLine("Please enter first number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter second number");
                int num2 = int.Parse(Console.ReadLine());

                int answer = num1 / num2;

                Console.WriteLine("Answer: {0}", answer);
            }
            catch
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
