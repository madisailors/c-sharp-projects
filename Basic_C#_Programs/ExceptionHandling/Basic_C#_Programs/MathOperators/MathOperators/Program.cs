using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine(combined);
            //Console.ReadLine();

            //int diff = 10 - 5;
            //Console.WriteLine("10 minus 5 =: " + diff);
            //Console.ReadLine();

            //int times = 5 * 10;
            //Console.WriteLine("10 multiplied by 5 = " + times);
            //Console.ReadLine();

            //double divide = 100.0 / 17.0;
            //Console.WriteLine("100 divided by 17 = " + divide);
            //Console.ReadLine();

            //int remainder = 11 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 69;
            //int currentTemp = 72;

            //bool isWarm = currentTemp >= roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();
            Console.WriteLine("Person 1:");
            Console.ReadLine();
            Console.WriteLine("Hourly rate: ");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2:");
            Console.ReadLine();
            Console.WriteLine("Hourly rate: ");
            int r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week: ");
            int h2 = Convert.ToInt32(Console.ReadLine());

            int salary1 = r1 * h1 * 52;
            Console.WriteLine("Annual salary of person 1:" + salary1);
            Console.ReadLine();

            int salary2 = r2 * h2 * 52;
            Console.WriteLine("Annual salary of person 2:" + salary2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();

            bool paycheck = salary1 > salary2;
            Console.WriteLine(paycheck);
            Console.ReadLine();

        }

    }
    
}
