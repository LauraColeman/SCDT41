using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relationships.cs
{
    public class Inheritance
    {
        string make;
        string model;


        public Inheritance(string Make, string Model)
        {
            this.make = Make;
            this.model = Model;

        }


        public void drive()
        {
            //Do something method

        }




        public class Car : Inheritance
        {
            public Car(string Make, string Model) : base(Make, Model)
            {
                this.make = Make;
                this.model = Model;

            }

            public void DoSomething()
            {
                //Do something method

            }

        }

    }
}
