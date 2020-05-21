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
            while (true)
            {
                Random random = new Random();
                int RandomNumber = random.Next(0, 5);
                bool retry = true;


                while (true)
                {

                    Console.WriteLine("Guess a number");
                    int guess = int.Parse(Console.ReadLine());


                    if (guess == RandomNumber)
                    {
                        Console.WriteLine("Correct!");
                        Console.WriteLine("Play Again?, y/n");
                        string answer = Console.ReadLine();
                        if (answer != "y")
                        {
                            retry = false;
                            if (!retry) break;
                        }
                        break;
                   
                   
                    }
                    else if (guess > RandomNumber)
                    {
                        Console.WriteLine("Too High!");
                    }

                    else if (guess < RandomNumber)
                    {
                        Console.WriteLine("Too Low!");
                    }

                    
                }

            }
        }
    }
}
