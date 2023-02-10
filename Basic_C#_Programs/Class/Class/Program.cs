using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();

            Console.WriteLine("please enter a number to be divided by 2");
            int userInput = Convert.ToInt32(Console.ReadLine());
            class1.Method(userInput);

            Class1 C = new Class1();

            int a = 100;
            Console.WriteLine("Before method call, value of a: {0}", a);
            C.getValue(out a); //calling function to get the value

            Console.WriteLine("After method call, value of a: {0}", a);
            Console.ReadLine();

            Class1 Class = new Class1();

            Console.WriteLine("please enter a different number to be divided by 2");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Class.Method(userInput1);

            Class2.Method(5);

        }
    }
}
