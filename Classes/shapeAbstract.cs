using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticabstractdemo.cs
{

    //Don't want to use shape as own
    //Use structureof child classes
    public abstract class Shape
    {

        public int height;
        public int width;

        public abstract void Draw();
       
    }



    public class Rectangle : Shape
    {

        
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }



    }



    public class Circle : Shape
    {

        int radius;

        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }



    }
}
