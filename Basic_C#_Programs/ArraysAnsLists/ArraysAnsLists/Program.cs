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

            string[] animals = { "dog", "cat", "horse", "mouse" };
            int[] num = { 5, 10, 15, 20 };

            Console.WriteLine("Please select an animal by its index (0-3): " + animals);
            int userInput = Convert.ToInt32(Console.ReadLine());

            for (int loop = 0; loop < 5; loop++ ) 
            {
                Console.WriteLine(animals[userInput]);
                Console.ReadLine();
            }

            Console.WriteLine("Please select a number by its index (0-3): " + num);
            int userInput1 = Convert.ToInt32(Console.ReadLine());

            for (int loop = 0; loop < 5; loop++)
            {
                Console.WriteLine(num[userInput1]);
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
