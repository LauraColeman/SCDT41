using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> recipes = new Dictionary<string, string>(); //creating new dicionary with 2 string types
            recipes.Add("Beans on Toast", "Bread, Beans, Butter");
            recipes.Add("Tomato Pasta", "Pasta,Passata,Cheese");
            recipes.Add("Sandwich", "Bread,Ham");

            Console.WriteLine("What recipe do you need?");
            string request = Console.ReadLine();

            if (recipes.TryGetValue("Sandwich", out string example)) //if this exist, outputs disctionary
            {
                Console.WriteLine("Ingredients Needed:{0}", example);
            }
            else{
                Console.WriteLine("Cannot Find Dictionary Value"); //error if not in dictionary
            }

            
            
        }







    }
}
