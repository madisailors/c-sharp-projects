using System;
 
namespace myConsoleProject.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \n Student Daily Report.");
            Console.ReadLine();
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\"");
            bool help = true;
            string help1 = help.ToString();
            Console.ReadLine();
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            int hours = 8;
            string hoursStudied = hours.ToString();
            Console.ReadLine();
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
