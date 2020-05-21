using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto2.cs
{
    class Program
    {
        static void Main(string[] args)
        {
/*
            var lotto = new int[6];

            for (int i = 0; i < lotto.Length; i++)
            {
                Random rand = new Random();
                lotto[i] = rand.Next(50);
                Console.WriteLine("Lotto number:{0}", lotto[i]);
                Console.ReadLine();

            }

            Array.Sort(lotto); //sort function of array

            for (int i=0; i < 6; i++)
            {
                Console.WriteLine("Lotto number : {0}", lotto[i]);
            }

            */


            //Lists
            var numbers = new List<int>(){1,2,3,4}; //create list of integers to the value numbers.Populate like array.
            numbers.Add(5); //add another value
            numbers.Add(6);
            numbers.Remove(4); //remove number 4
            numbers.RemoveAt(1); //removes from index, 2=1.
          
           foreach(var count in numbers) //sequentially work through whatever in list, cycle until reaches end.
            {
                Console.WriteLine("List Element:{0}", count);
            }
        }
    }
}
