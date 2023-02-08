using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {

            Num num = new Num();


            Console.WriteLine("Please enter a number to be subtracted by 10: ");
            int input = Convert.ToInt32(Console.ReadLine());  // reads user input and converts it to an integer, then stores the result as the variable called input
            num.Subtracts(input);
            Console.WriteLine();
            Console.ReadLine();

            Num num1 = new Num();
            Console.WriteLine("Please enter a number to be added to 10: ");
            int input2 = Convert.ToInt32(Console.ReadLine());
            num1.Adds(input2);  // Calling the method from Num class 
            Console.WriteLine();   //displaying output from Method
            Console.ReadLine();

            Num num2 = new Num();
            Console.WriteLine("Please enter a number to be multiplied by 10: ");
            int input3 = Convert.ToInt32(Console.ReadLine());
            num2.Adds(input3);  // Calling the method from Num class 
            Console.WriteLine();   //displaying output from Method
            Console.ReadLine();

        }
    }
}
