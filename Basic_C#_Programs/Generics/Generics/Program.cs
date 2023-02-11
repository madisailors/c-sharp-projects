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

            
            
          
        }
    }
}
