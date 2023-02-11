using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static int operator== (Employee employee, ID id)
        {
            employee.ID.Equals(id);

        }
        public static int operator!= (Employee employee, ID id)
        {
            employee.ID.Equals(id);

        }
    }
}
