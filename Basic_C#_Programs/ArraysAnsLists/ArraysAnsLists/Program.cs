using System;
using System.Collections.Generic;

namespace ArraysAnsLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> intlist = new List<int>();
            //intlist.Add(4);
            //intlist.Add(10);
            //intlist.Add(100);

            //Console.WriteLine(intlist);
            //Console.ReadLine();

            List<string> stringList = new List<string>();
            stringList.Add("brown");
            stringList.Add("blue");
            stringList.Add("green");
            stringList.Add("Hazel");

            Console.WriteLine("Please select your eye color from the following list based on its index(0-3):");
            int color = Convert.ToInt32(Console.ReadLine());


            if (color >= 0 && color <= 3)
            {
                Console.WriteLine(stringList[color]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry, invalid index number, please try again try again");
                Console.ReadLine();
            }

            string[] animals = { "dog", "cat", "horse", "mouse" };
            int[] num = { 5, 10, 15, 20 };

            Console.WriteLine("Please select an animal by its index (0-3): " + animals[0] + animals[1] + animals[2] + animals[3]);
            int userInput = Convert.ToInt32(Console.ReadLine());


            if (userInput >= 0 && userInput <= 3)
            {
                Console.WriteLine(animals[userInput]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry, invalid index number, please try again");
                Console.ReadLine();
            }

            Console.WriteLine("Please select a number by its index (0-3): " + num[0] + num[1] + num[2] + num[3]);
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            if (userInput1 >= 0 && userInput1 <= 3)
            {
                Console.WriteLine(num[userInput1]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry, invalid index number, please try again");
                Console.ReadLine();
            }


            //int[] numarray = new int[5];
            //numarray[0] = 5;
            //numarray[1] = 2;
            //numarray[2] = 10;
            //numarray[3] = 200;
            //numarray[4] = 5000;

            //int[] numarray1 = new int[] { 5, 2, 10, 200, 5000 };

            //int[] numarray2 = { 5, 2, 10, 200, 5000 }; //easiest way 

            //numarray2[5] = 650; // editing 5th number in array

            //Console.WriteLine(numarray[3]);
            //Console.ReadLine();
        }
    }
}
