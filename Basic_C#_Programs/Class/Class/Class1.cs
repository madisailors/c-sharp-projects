using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Class1
    {
        public void Method(int num)
        {
            int result = num / 2;
            Console.WriteLine(result);
            Console.ReadLine(); 
        }

        public void Method(int num, int num1 = 5) //overload method, different parameters but same method name (Method())
        {
            int result = num * 2;
            Console.WriteLine(result);
            Console.WriteLine(num1);
            Console.ReadLine();
        }

        public void getValue(out int x)  //output parameters
        {
            int temp = 5;
            x = temp;
        }

    }
}

