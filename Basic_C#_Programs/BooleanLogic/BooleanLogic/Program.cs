using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && false);
            //Console.ReadLine();

            //Console.WriteLine(true || false);
            //Console.ReadLine();

            // == operator
            // != operator 
            // ^ XOR operator, will generate 'true' if one is true, but not both

            Console.WriteLine("Car Insurance Application");
            Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever recieved a DUI?");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets have you recieved?");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine



        }
    }
}
