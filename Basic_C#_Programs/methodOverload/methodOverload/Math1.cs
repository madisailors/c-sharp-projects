using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverload
{
    class Math1
    {
        public int Method1(int Num1, int Num2 = 5)
        {
            int result = Num1 + Num2;
            return result;
        }
    }
}
