using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Console.WriteLine("Please enter a number to be added to 5");
            int userInput = Convert.ToInt32(Console.ReadLine()); //converting input to integer
            Console.WriteLine("Please enter a second number to be displayed");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            class1.Method(userInput, userInput2); //calling method

                
        }
    }
}
