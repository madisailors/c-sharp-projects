using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Madi";
            //string quote = "The woman said, \"hello\" Madi.";
            //string filename = "C:\\Users\\Madi"; // or @ before file name and no double slash
            //bool trueOrFalse = name.Contains("i");
            //name = name.ToLower(); // also ToUpper();
            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("my name is madi");  //appends an immutable string instead of creating a new one
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
