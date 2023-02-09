using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Math num = new Math();

            Console.WriteLine("Please enter a number to multiply by 15: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int number1 = num.Method(input);
            Console.WriteLine(number1);
            Console.ReadLine();


        }
        // Add a second method to the class with the
        // same name that will take in a decimal,
        // create a diffent math operation for it,
        // then return the answer as an integer.
    }
}
