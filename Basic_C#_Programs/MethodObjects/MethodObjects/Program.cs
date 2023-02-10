using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(); //instantiating class and assigning variable

            employee.FirstName =  "Sample"; 
            employee.LastName = "Student";  //assigning string value to property
            employee.SayName(); //calling method from superclass person
            Console.ReadLine();
        }
    }
}
