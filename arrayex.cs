using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[5] {5,6,34,22,39}; //empty array

                       
            Console.WriteLine(numbers[2]); //will output 34.

            //multidimensional

            var multiArray = new int[2, 4] { {34, 2, 12, 34 },{2, 4, 6, 8} };  //array 2 stacks x 4 across //2 curly brackets inside 1 curly brackets for 2 stacks



            //jaggedarray
            var jagged = new int[3][]; //empty square bracket in jagged 

            //each array index is a new array in jagged
            jagged[0] = new int[4];//row of 4
            jagged[1] = new int[2];//row of 3
            jagged[2] = new int[3];

            //putting random values into an array with a loop

            var lotto = new int[7];

            for(int i = 0; i < lotto.Length; i++) //counter //lotto length, if array no. changes //loop to fill array
            {
                Random rand = new Random(); //create new random
                lotto[i] = rand.Next(0, 50); //call on lotto, numbers 0-50 //i will start at 0 and count up //put value in each index
                Console.WriteLine("Lotto Number: {0}", lotto[i]); //output numbers
            }


            
        }
    }
}
