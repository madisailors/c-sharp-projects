using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodObjects
{
    class Person
    {
        public string FirstName { get; set; }     // prop + tab tab for adding properties
        public string LastName { get; set; }

        public void SayName()
        {
            
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            
        }
    }
}
