using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine(); 

            Console.WriteLine("What is your favorite number?");
            string yourNum = Console.ReadLine();
            int yourNumb = Convert.ToInt32(yourNum);
            int total = yourNumb + 5;
            Console.WriteLine("Your favorite number 5 is: " + total);
            Console.ReadLine();
        }
    }
}
