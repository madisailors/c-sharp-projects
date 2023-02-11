using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static Employee operator== (Employee employee, ID id)
        {
            employee.ID.CompareTo(id);

        }
        public static Employee operator!= (Employee employee, ID id)
        {
            employee.ID.CompareTo(id);

        }
    }
}
