using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticabstractdemo.cs
{
    public class User
    {

        public int ID;
        public string Name;
        public string Role;
        public string Hobbies;


        public User()
        {

        }

        public User(int id, string name, string role)
        {


        }


        public User(int id, string name, string role, string hobbies)
        {


        }


        public void Retrieve()
        {
            Console.WriteLine("These are my details");

        }
    }
}
