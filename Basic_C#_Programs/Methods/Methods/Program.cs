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
            num = subtract(num);

            Console.WriteLine("Please enter a number");
            int input = Console.WriteLine(num.ToString());
        }
    }
}
