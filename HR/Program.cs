using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.cs
{
    public class Program
    {
        static void Main(string[] args)
        {
            Staff staff1 = new Staff("John", "Smith", "BTC College", 40000 , 1234);
            Staff staff2 = new Staff("Jane", "Doe", "BTC College", 40000, 5678);

            Visitor visitor1 = new Visitor("Thingym", "Bob", "One Hour", "John Doe");
            Visitor visitor2 = new Visitor("WhatZit", "TooYa", "One Day", "Jane Doe");

            Client client1 = new Client("Pat", "Pman", "Postman", 224);
            Client client2 = new Client("Alan", "Titchmarsh", "Gardener", 223);

            staff1.Introduce();
            staff1.ShowPass();
            staff2.Introduce();
            staff2.ShowPass();

            visitor1.Introduce();
            visitor1.HereToSee();
            visitor2.Introduce();
            visitor2.HereToSee();

            client1.Introduce();
            client1.ShowJob();
            client1.SignedIn();
            client2.Introduce();
            client2.ShowJob();
            client2.SignedIn();
            client1.SignedOut();
            client2.SignedOut();


            staff1.salarydeclare();
            staff2.salarydeclare();
            



        }
        
    }
}
