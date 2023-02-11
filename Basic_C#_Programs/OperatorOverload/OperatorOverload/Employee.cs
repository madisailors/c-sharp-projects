using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator== (Employee id1, Employee id2) //passing in parameters
        {
            if (id1.Equals(id2))   //comparing parameters
                return true;
            else
                return false;

        }
        public static bool operator!= (Employee id1, Employee id2)
        {
            if (id1.Equals(id2))
                return true;
            else
                return false;

        }
    }
}
