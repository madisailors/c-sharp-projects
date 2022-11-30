using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 42;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess a number?");
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess a number?");
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess a number?");
                        break;
                    case 42:
                        Console.WriteLine("You guessed the number 42, that is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You're wrong!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            //while (!isGuessed);   //! or (isGuessed == False)
            while (!isGuessed);
            
            Console.Read();

            int counter = 1;
            while (counter <= 10)
            {
                if (counter != 7)
                {
                }
                Console.WriteLine("{0}", counter);
                counter++;
            }
            Console.ReadLine();
        }
    }
}
