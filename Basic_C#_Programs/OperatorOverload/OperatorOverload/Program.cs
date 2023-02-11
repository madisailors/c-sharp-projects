using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();

            employee1.Id = 1;
            employee1.FirstName = "Jill";
            employee1.LastName = "Jones";


            Employee employee2 = new Employee(); //instantiating emploee object

            employee2.Id = 2;              //assigning values to object properties
            employee2.FirstName = "Jack";
            employee2.LastName = "Smith";

            if (employee1.Id == employee2.Id)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.ReadLine();               //displaying results



            
        }
    }
}
