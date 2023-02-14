using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The current date & time is : ");
            DateTime now = DateTime.Now;         // assigning current datetime to variable 'now'
            Console.WriteLine(now);

            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine()); // converting user input to int and assigning it to variable

            DateTime result = now.AddHours(num);   //using addHours method to add #of hours (num) to current datetime
            Console.WriteLine("In {0} hours, the date and time will be: ", num);
            Console.Write(result);
            Console.ReadLine();
        }
    }
}
