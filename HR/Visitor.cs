using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.cs
{
    class Visitor : Person
    {

        public string Time; //length of visit
        public string ToSee; //here to see


        public Visitor()
                : base("Test") //parent doesnt take constructor with 0 arguments
        {
        }
        public Visitor(string name, string lastname, string time, string toSee)
                : base("Test")
        {

            this.Time = time;
            this.ToSee = toSee;

        }
        public void HereToSee()
        {
            Console.WriteLine("I am here to see {0}", ToSee);
            Console.WriteLine("I am here for {0}", Time);

        }
    }
}
