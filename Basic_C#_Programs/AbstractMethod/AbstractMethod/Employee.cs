using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    public class Employee : Person, IQuittable
    {
        public override void SayName() //overriding sayName() in Person.cs
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            Console.WriteLine(" Quit method had been called ");
            Console.ReadLine();
        }
    }
   
}
