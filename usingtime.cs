using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingtime.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var submissionDate = new DateTime(3, 2, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            var tomorrow = now.AddDays(1);  //add or removes a day from date
            var yesterday = today.AddDays(-1);

            submissionDate = DateTime.Now;
            Console.WriteLine(submissionDate.ToLongDateString()); //custom format

            Console.WriteLine(tomorrow);
            Console.WriteLine(yesterday);

           */

            bool isRunning = true;
            do
            {
                Console.WriteLine("Please Enter the Nature of Your Complaint");
                string title = Console.ReadLine();
                var complaint = new ComplaintLog();
                complaint.Title = title;
                complaint.LaunchComplaint();
                isRunning = false;

            } while (isRunning);







        }
    }
}
