using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }
    }

    //public void Display()
    //{
    //    foreach (Employee<int> emp in Things)
    //    {
    //        Console.WriteLine(emp);
    //    }
    //}
}
