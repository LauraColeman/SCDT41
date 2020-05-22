using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relationships.cs
{
    class Aggregation
    {
        public class Address
        {
            string street;
            int number;



        }

        public class Person
        {
            private Address address;
            private string name;


            public Person(Address Address, string Name)
            {
                this.address = Address;
                this.name = Name;
            }

        }

    }
}
