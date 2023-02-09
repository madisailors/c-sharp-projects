using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverload
{
    class Math
    {
        public int Method(int num)
        {
            int result = num * 15;
            return result;
        }

        public decimal Method(decimal num1)
        {
            decimal result = num1 + 5;
            return result;
        }

        public int Method(string input2)
        {
            string input = Convert.ToInt32(Console.ReadLine());
            int result = input / 2;
            return result;
        }
    }
}
