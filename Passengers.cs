using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task1.cs
{
    public class Passengers 
    {
        
        public List<int> List1 = new List<int>(); //Declare new list for inputted values to be stored in. //Prebooked passengers.
        public List<int> List2 = new List<int>(); //Passengers that pay on arrival.
        public Dictionary<string, int> store = new Dictionary<string, int>(); //Dictionary to store coach label and number of total passengers in each.

        
         //Method to allow user to input number of passengers that have pre-booked tickets or paid on arrival. Cast to allow input of an int from string.


        public void PassengerNumbers()
        {

            
            //Passengers that have pre-booked.
            //While loop checks for valid user input and lets them re-enter if inputted value exceeds the number of seats available for the customer type (80 for pre-book and 80 for pay on arrival).

            while (true)
            {
                Console.WriteLine("Enter the number of passengers who have pre-booked for coach A:");
                int coachA = Convert.ToInt32(Console.ReadLine());
                if (coachA > 80) //Sets number of seats in train carriage - Loop allows user to re-enter value if it exceeds this.
                {
                    Console.WriteLine("There are only 80 seats in Coach A. Please enter a valid value");
                    Convert.ToInt32(Console.ReadLine());                                                                                                                                                                                                                                                                                                                 
                }

                if (coachA < 80)
                {
                    List1.Add(coachA); //Adds value to List 1 

                }


                Console.WriteLine("Enter the number of passengers who have pre-booked for coach B:");
                int coachB = Convert.ToInt32(Console.ReadLine());
                if (coachB > 80)
                {
                    Console.WriteLine("There are only 80 seats in Coach B. Please enter a valid value");
                    Convert.ToInt32(Console.ReadLine());
                }

                if (coachB < 80)
                {
                    List1.Add(coachB);

                }

                Console.WriteLine("Enter the number of passengers who have pre-booked for coach C:");
                int coachC = Convert.ToInt32(Console.ReadLine());
                if (coachC > 80)
                {
                    Console.WriteLine("There are only 80 seats in Coach C. Please enter a valid value");
                    Convert.ToInt32(Console.ReadLine());
                }

                if (coachC < 80)
                {
                    List1.Add(coachC);

                }

                Console.WriteLine("Enter the number of passengers who have pre-booked for coach D:");
                int coachD = Convert.ToInt32(Console.ReadLine());
                if (coachD > 80)
                {
                    Console.WriteLine("There are only 80 seats in Coach D. Please enter a valid value");
                    Convert.ToInt32(Console.ReadLine());
                }

                if (coachD < 80)
                {
                    List1.Add(coachD);

                }

         //Passengers that have paid on arrival.

                

            Console.WriteLine("\nEnter the number of passengers who have paid on arrival for coach A:");
            int coachA2 = Convert.ToInt32(Console.ReadLine());
            if (coachA2 > 80)
            {
                Console.WriteLine("There are only 80 seats in Coach A. Please enter a valid value");
                Convert.ToInt32(Console.ReadLine());
            }

            if (coachA2 < 80)
            {
                List2.Add(coachA2);  //Adds value to List 2

            }

            Console.WriteLine("Enter the number of passengers who have paid on arrival for coach B:");
            int coachB2 = Convert.ToInt32(Console.ReadLine());
            if (coachB2 > 80)
            {
                Console.WriteLine("There are only 80 seats in Coach B. Please enter a valid value");
                Convert.ToInt32(Console.ReadLine());
            }

            if (coachB2 < 80)
            {
                List2.Add(coachB2);

            }

            Console.WriteLine("Enter the number of passengers who have paid on arrival for coach C:");
            int coachC2 = Convert.ToInt32(Console.ReadLine());
            if (coachC2 > 80)
            {
                Console.WriteLine("There are only 80 seats in Coach A. Please enter a valid value");
                Convert.ToInt32(Console.ReadLine());
            }

            if (coachC2 < 80)
            {
                List2.Add(coachC2);

            }

            Console.WriteLine("Enter the number of passengers who have paid on arrival for coach D:");
            int coachD2 = Convert.ToInt32(Console.ReadLine());
            if (coachD2 > 80)
            {
                Console.WriteLine("There are only 80 seats in Coach D. Please enter a valid value");
                Convert.ToInt32(Console.ReadLine());
            }

            if (coachD2 < 80)
            {
                List2.Add(coachD2);


            }

            int sum1 = List1.Sum();
            int sum2 = List2.Sum(); //Totals values of pay on arrival customers in List 2


                //Total Number of passengers on train and in coaches.

            Console.WriteLine("The total number of passengers that have paid on arrival is {0}.", sum2);
            Console.WriteLine("\nThe total number of passengers on the train is {0}.", sum1 + sum2);
            

            Console.WriteLine("\nThe total number of passengers that have pre-booked is {0}.", sum1);


                //Adds coach values for coach ID, prebook and arrivals to a third list to be sorted and printed.

                store.Add("Coach A", coachA + coachA2);
                store.Add("Coach B",coachB + coachB2);
                store.Add("Coach C",coachC + coachC2);
                store.Add("Coach D",coachD + coachD2);


                //Sorts and Prints values to Console in ascending order.
                //Specify sorting by value to sort by integer.
                var items = from pair in store
                            orderby pair.Value ascending
                            select pair;

                // Display results.
                foreach (KeyValuePair<string, int> pair in items)
                {
                    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                }

                //Breaks loop and prevents programme from running infinitely.
                break;
            }
        }




       
         
        


                }


               




            }
            


       
 



