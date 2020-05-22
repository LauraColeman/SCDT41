using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticabstractdemo.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //create objects from standard class
            User Aaron = new User();
            User Brad = new User();
            User Jay = new User();

            //Call objects method
            Aaron.Retrieve();

            //Call methods from standard class
            //don't need/can't create objects


            Checker.CalculateSum(1, 2);
            Checker.CalculateSum(21, 2);
            Checker.CalculateSum(1, 25);


            Checker.CalculateProduct(4, 8);
            Checker.CalculateProduct(9, 8);
            Checker.CalculateProduct(234, 3);


            Checker.ShowLog();


            //Using and abstract class for structure
            //Cannot implement abstract classes 


            Rectangle rect = new Rectangle();
            rect.height = 10;
            rect.width = 20;

            rect.Draw();

            Circle circ = new Circle();
            circ.width = 100;

            circ.Draw();

            //Below won't work, can't instantiate abstract class
            //Shape test = new Shape();



        }
    }
}
