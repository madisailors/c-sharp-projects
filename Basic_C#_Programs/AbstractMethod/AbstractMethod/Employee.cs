﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractMethod
{
    public class Employee : Person, IQuittable
    {
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
        public void Quit(Person person) //implementing function from Iquittable interface
        {
            Console.WriteLine(LastName);
            Console.ReadLine();
        }

        IQuittable quittable = new IQuittable(Quit);
        

    }
    //Use polymorphism to create an object of type IQuittable and call
    //the Quit() method on it.Hint: an object can be of an interface
    //type if it implements that specific interface.
}
