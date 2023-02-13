using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>(); //instantiating class
            {
                new Employee { FirstName = "Joe", LastName = "Smith", Id = 01 };
                new Employee { FirstName = "John", LastName = "White", Id = 02 };
                new Employee { FirstName = "Sally", LastName = "Sue", Id = 03 };
                new Employee { FirstName = "Nancy", LastName = "Black", Id = 04 };
                new Employee { FirstName = "Pat", LastName = "Doe", Id = 05 };
                new Employee { FirstName = "Joe", LastName = "Pierce", Id = 06 };
                new Employee { FirstName = "James", LastName = "Fitzgerald", Id = 07 };
                new Employee { FirstName = "Amy", LastName = "West", Id = 08 };
                new Employee { FirstName = "Becky", LastName = "Gomez", Id = 09 };
                new Employee { FirstName = "Carl", LastName = "Greene", Id = 10 };
            }
                                         

            foreach(Employee emp in employee)
            {
                if(emp.FirstName == "Joe")
                    {
                    Console.WriteLine(emp);
                    Console.ReadLine();
                    }
            }
            Console.ReadLine();

            List<Employee> newList1 = employee.Where(n => n.FirstName == "Joe").ToList(); //adding all employees with first name joe to new list
            Console.WriteLine(newList1);

            List<Employee> newList = employee.Where(x => x.Id >= 5).ToList();
            Console.WriteLine(newList);

            Console.ReadLine();


        }
    }
}
