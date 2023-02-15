using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    class Employee
    {
        public Employee(string name, int id) //assigning parameters for employee
        {
            Name = name;
            Id = id;

        }
        public Employee(string name) : this(name, 0) //chaining constructors and assigning default int
        {
        }

        public string Name { get; set; }
        public int Id { get; set; }
    }
}
