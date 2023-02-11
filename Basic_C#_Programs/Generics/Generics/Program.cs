using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string> { "one", "two", "three" };

            Employee<int> employee1 = new Employee<int>();
            employee1.Things = new List<int> { 1, 2, 3 };

            foreach (int emp in employee1.Things)
            {
                Console.WriteLine(emp);
            }

            foreach (string emp1 in employee.Things)
            {
                Console.WriteLine(emp1);
            }
          Console.ReadLine();

        }
    }
}
