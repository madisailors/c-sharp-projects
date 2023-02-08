using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Num num = new Num();
            

            Console.WriteLine("Please enter a number to be subtracted by 10");
            int input = Convert.ToInt32(Console.ReadLine());  // reads user input and converts it to an integer, then stores the result as the variable called input
            num.subtract(input);

        }
    }
}
