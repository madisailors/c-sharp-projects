using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiating class

            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName(); //calling method from Employee class
            Console.ReadLine(); //displaying output

            IQuittable quittable = new Employee();
 
            quittable.Quit();

        }
    }
}
