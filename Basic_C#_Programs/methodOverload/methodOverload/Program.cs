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

            Math num1 = new Math();

            Console.WriteLine("Please enter a decimal number to be added to 5: ");
            decimal input1 = Convert.ToDecimal(Console.ReadLine());
            decimal number2 = num1.Method(input1);
            Console.WriteLine(number2);
            Console.ReadLine();

            Math num2 = new Math();

            Console.WriteLine("Please enter a number to be divided by 2");
            int input2 = Convert.ToInt32(Console.ReadLine());
            int number3 = num2.Method(input2);
            Console.WriteLine(number3);
            Console.ReadLine();


        }
        // Add a second method to the class with the
        // same name that will take in a decimal,
        // create a diffent math operation for it,
        // then return the answer as an integer.
    }
}
