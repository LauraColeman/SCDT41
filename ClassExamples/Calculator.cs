using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input first number");
            float firstNum = float.Parse(Console.ReadLine());


            Console.WriteLine("Input second number");
            float secondNum = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter your operation +. -, /, *"); //can use string or char
            char operation = Convert.ToChar(Console.ReadLine()); //cast

            float total;

           switch (operation)
            {
                case '+': //add firstNum + secondNum
                    total = firstNum + secondNum; //totl of calculation
                        Console.WriteLine(total);
                        break;

                case '-': //take first + secondNum
                    total = firstNum - secondNum;
                        Console.WriteLine(total);
                        break;

                case '*': //multiply first + secondNum
                    total = firstNum * secondNum;
                        Console.WriteLine(total);
                    break;

                case '/': //divide first + secondNum
                    total = firstNum / secondNum;
                    Console.WriteLine(total);
                    break;

            }

            }








           
        }
    }

