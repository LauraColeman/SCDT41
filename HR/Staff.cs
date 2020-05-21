using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.cs
{
    class Staff : Person
    {

        public string SchoolName;
        public int Salary;
        public int Id;

        public Staff()
            : base("errorfill") //parent doesnt take constructor with 0 arguments
        {
        }

        public Staff(string name, string lastname, string schoolname, int salary, int Id)
        : base(name)
        {


            this.SchoolName = schoolname;
            this.Salary = salary;
            this.Id = Id;


        }

        public void ShowPass()
        { Console.WriteLine("My Id is {0}", Id);

        }
    

        public void salarydeclare()
        {
            Console.WriteLine("My Salary Is {0}",Salary );

        }



    }
        
    }

