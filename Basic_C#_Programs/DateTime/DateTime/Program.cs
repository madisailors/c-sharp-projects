using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The current date & time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);

            Console.WriteLine("Please enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            DateTime result = now.AddHours(num);
            Console.WriteLine("In {0} hours, the date and time will be: ", num);
            Console.Write(result);
            Console.ReadLine();




        }
    }
}
