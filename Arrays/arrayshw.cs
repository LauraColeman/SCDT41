using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Jagged Array being used - allow different no. of elements in each array.

            var picArray = new char[3][]; //declare array has 3 elements
            picArray[0] = new char[3] { 'o', 'x', 'o' }; //initialise elements, 3 chars in each. [3]
            picArray[1] = new char[3] { 'x', 'o', 'x' };
            picArray[2] = new char[3] { 'o', 'x', 'o' };

            //for loop - Sum of columns

            for (int row = 0; row < picArray.Length; row++)//.Length = length of array. Reference each array individually. 
                //(coordinates)row = 0 column = 0 then c=1,c=2
            {
                for (int column = 0; column < picArray[row].Length; column++) //Nested. Row = 1 Col = 0. Until all printed. Only exits when reaches length.
                {
                    Console.Write(picArray[column][row]);
                }
                Console.WriteLine("\n"); //split over multiple lines "x //new line// x //newline// x"

            }
            Console.ReadLine();
        }
        //add user input - use for/while loop?
    }
}
