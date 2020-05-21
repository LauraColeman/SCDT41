using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.cs
{
    public class PreBook
    {




        //Method to allow user to input number of passengers that have pre-booked tickets. Cast to allow input of an int from string.

        public void PreBookNumbers()
        {
            List<int> list = new List<int>(); //Declare new list for inputted values to be stored in. 

            

            Console.WriteLine("Enter the number of passengers who have pre-booked for coach A:");
            int coachA = Convert.ToInt32(Console.ReadLine());
            list.Add(coachA);


            Console.WriteLine("Enter the number of passengers who have pre-booked for coach B:");
            int coachB = Convert.ToInt32(Console.ReadLine());
            list.Add(coachB);

            Console.WriteLine("Enter the number of passengers who have pre-booked for coach C:");
            int coachC = Convert.ToInt32(Console.ReadLine());
            list.Add(coachC);

            Console.WriteLine("Enter the number of passengers who have pre-booked for coach D:");
            int coachD = Convert.ToInt32(Console.ReadLine());
            list.Add(coachD);

            Console.WriteLine("The total number of passengers that have pre-booked is {0}.", coachA + coachB + coachC + coachD); //Totals values of user input

        }

    


        }

    }

