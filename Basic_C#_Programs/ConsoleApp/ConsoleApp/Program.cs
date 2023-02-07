using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //part 1

            string[] animals = { "dog", "cat", "horse", "mouse" };

            Console.WriteLine("Please type an animal to add to the array");
            string input = Console.ReadLine();

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i] = animals[i]+(input);   //take string at animals array at position i, add the user input to it, save it back to the array at position i
            }

            for (int i=0; i<animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }
            Console.ReadLine();

            //assignment pt 2
            while (true)
            {
                Console.WriteLine("hello world"); //infinite loop
                break; //ends infinite loop
            }

            //assignment part 3
            int counter = 1;

            while (counter < 10)
            {
                Console.WriteLine("{0}", counter);
                counter++;
            }
            Console.ReadLine();

            int counter1 = 1;

            while (counter1 <= 10)
            {
                Console.WriteLine("{0}", counter1);
                counter1++;
            }
            Console.ReadLine();

            //assignment part 4

            List<string> birds = new List<string> { "Chicken", "Duck", "Crow", "Raven" };

            Console.WriteLine("Please type a bird to search through the list");
            string search = Console.ReadLine();               
            
                if (birds.Contains(search))
                 {
                    for (int i = 0; i < birds.Count(); i++)
                    {
                        if (search == birds[i])
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    }
                }
                else
                {
                    Console.WriteLine("The item you entered does not match any of the birds on the list. please try again.");
                }
            Console.ReadLine();


            //assignment part 5

            List<string> bugs = new List<string> { "ladybug", "ant", "fly", "beetle", "fly" };

            Console.WriteLine("Please select a bug from the following list: " + bugs);

            string bugSearch = Console.ReadLine();

            if (bugs.Contains(bugSearch))
            {
                for (int i = 0; i < bugs.Count(); i++)
                {
                    if (search == bugs[i])
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("The item you entered does not match any of the bugs on the list. please try again.");
            }
            Console.ReadLine();



        }
    }
}
