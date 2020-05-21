using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.cs
{
    class Client : Person
    {
        public string Job;
        public int Id;
        

        public Client()
               : base("Test") //parent doesnt take constructor with 0 arguments
        {

        }

        public Client(string name, string lastname, string job, int Id)
            : base("Test") //parent doesnt take constructor with 0 arguments
        {

            this.Job = job;
            this.Id = Id;

        }

        public void ShowJob()
        {
            Console.WriteLine("My Id is {0}", Id + "I am the {1}", Job);
        }
        public void SignedIn()
        {
            Console.WriteLine("I have signed in");
        }

        public void SignedOut()
        {
            Console.WriteLine("I have signed out");
        }
    }
}
