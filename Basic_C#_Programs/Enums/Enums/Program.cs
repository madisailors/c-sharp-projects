using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum DaysOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter which day of the week it is");
                Console.ReadLine();
                foreach (string v in Enum.GetNames(typeof(DaysOfWeek)))
                {
                    Console.WriteLine("{0} = {1:D}", v, Enum.Parse(typeof(DaysOfWeek), v));
                }
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }
            Console.ReadLine();
        }
    }
}

