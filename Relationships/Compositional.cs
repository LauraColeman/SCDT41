using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace relationships.cs
{
    class Compositional
    {
        public class Room
        {
            int size;
            string name;
            string purpose;



            public Room(string Name)
            {
                this.name = Name;

            }
            
        }

        public class House
        {
            public string address;
            Room bedroom = new Room("Bedroom");
            Room livingRoom = new Room("Living Room");
            Room bathroom = new Room("Bathroom");



            public void AddTenancy()
            {
                //do something method

            }
            

        }
    }
}
