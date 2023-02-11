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
            return id1.Id == id2.Id;  //using overridden operator to compare

        }
        public static bool operator!= (Employee id1, Employee id2)
        {
            return id1.Id != id2.Id;

        }
    }
}
