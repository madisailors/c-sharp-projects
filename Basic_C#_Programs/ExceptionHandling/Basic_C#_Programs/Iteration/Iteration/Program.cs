using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testScores = new List<int>() { 98, 90, 99, 70, 71, 85 };
            List<int> passingScore = new List<int>();

            foreach (int score in testScores)
            {
                if (score >= 85)
                {
                    passingScore.Add(score);
                }
            }

            Console.WriteLine(passingScore.Count);
            Console.ReadLine();

            //List<string> animals = new List<string> { "chicken", "duck", "crow", "raven" };

            //foreach (string animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(90);
            //testScores.Add(77);
            //testScores.Add(94);
            //testScores.Add(80);
            //testScores.Add(87);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score " + score);
            //    }
            //}
            //Console.ReadLine();

            //int[] testScores = { 98, 99, 92, 85, 70, 82, 34, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] animals = { "cat", "dog", "rabbit", "horse" };
            //for (int i = 0; i < animals.Length; i++)
            //{ 
            //    Console.WriteLine(animals[i]);  //prints whole array
            //}

            //for (int i = 0; i < animals.Length; i++)
            //{
            //    if (animals[i] == "horse")
            //    {
            //        Console.WriteLine(animals[i]);
            //    }
            //}
            //Console.ReadLine();
        }
    }
}
