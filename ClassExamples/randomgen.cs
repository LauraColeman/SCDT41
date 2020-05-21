using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomgen.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int RandomNumber = random.Next(0, 5);

            Console.WriteLine("Guess a number");
            int guess = int.Parse(Console.ReadLine());      
           

        
            if (guess > RandomNumber)
            {
                Console.WriteLine("Too High!");
            }

            else if (guess < RandomNumber)
            {
                Console.WriteLine("Too Low!");
            }

            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}
