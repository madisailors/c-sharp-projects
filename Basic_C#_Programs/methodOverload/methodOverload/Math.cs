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
            int input = Convert.ToInt32(num1);
            int result = input + 5;
            return result;
        }

        public int Method(string input2)
        {
            int input = Convert.ToInt32(input2);  //converting user input into an int
            int result = input / 2;   // preforming math equation on user input
            return result;
        }
    }
}
