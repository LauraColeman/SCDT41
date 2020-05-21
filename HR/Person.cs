using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.cs
{
    class Person
    {
        public string Name;
        public string LastName;
        private string v;

        public Person(string v)
        {
            this.v = v;
        }

        public Person (string name, string lastname)
            {
            this.Name = name;
            this.LastName = lastname;

}
        public void Introduce()
        {
            Console.WriteLine("My Name is {0}", Name + LastName);
           
        }

    }
}
