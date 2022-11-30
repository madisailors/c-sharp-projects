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
            string name = "Madi";
            string hometown = "Portland";
            string eyeColor = "Brown";

            Console.WriteLine(name + hometown + eyeColor);
            Console.ReadLine();
            //string quote = "The woman said, \"hello\" Madi.";
            //string filename = "C:\\Users\\Madi"; // or @ before file name and no double slash
            //bool trueOrFalse = name.Contains("i");
            name = name.ToLower(); // also ToUpper();
            name = name.ToUpper();
            Console.WriteLine(name);
            Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("The cow jumped over the moon;"); //appends an immutable string instead of creating a new one
            sb.Append("The little dog laughed \nTo see such sport, ");
            sb.Append("And the dish ran away with the spoon.");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
