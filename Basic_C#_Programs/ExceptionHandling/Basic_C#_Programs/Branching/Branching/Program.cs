using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            //int roomtemp = 70;
            //Console.WriteLine("Hello! What's your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hello, " + name + ", what is the temperature where you are?");
            //int temp = Convert.ToInt32(Console.ReadLine());

            //if (temp == roomtemp)
            //{
            //    Console.WriteLine("it is currently room temperature");
            //}
            //else if (temp > roomtemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (temp < roomtemp)
            //{
            //    Console.WriteLine("It's cooler than room temperature");
            //}
            //Console.ReadLine();
            //int currentTemp = 72;
            //int roomTemp = 70;

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("it is exactly room temperature");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is currently warmer than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("it is not room temp");
            //}
            //string compareResult = currentTemp == roomTemp ? "it is room temp" : "it is not room temp";
            //Console.WriteLine(compareResult);
            //Console.ReadLine();

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.ReadLine();
            Console.WriteLine("What is the package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via package express.");
            }
            else
            {
                Console.WriteLine("What is the package width?");
                int width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package length?");
                int length = Convert.ToInt32(Console.ReadLine());

                if ((width + length + height) > 50)
                {
                    Console.WriteLine("Your package is too big to be shipped via package express.");
                }
                else
                {
                    Console.WriteLine("your quote is: $" + width * length * height * weight / 100);
                }
                Console.ReadLine();

            }
        }
            
    }
}
