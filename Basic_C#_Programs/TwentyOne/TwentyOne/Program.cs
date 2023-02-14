using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel & Casino. Start by telling me your name. ");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" )
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivleyPlaying = true;
                while (player.isActivleyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing, {0}", playerName);
            }
            Console.WriteLine("Feel free to look around the casino, bye for now!");
            Console.Read();

        }

        
        }

//    TwentyOneGame game = new TwentyOneGame();
//    game.Players = new List<string>() { "bob", "sally", "john" };
//  game.ListPlayers();
//  Console.ReadLine();

    //public static Deck Shuffle(Deck deck, int times)
    //{
    //     for (int i = 0; i < times; i++) //iterating through parameter times until int input is reached
    //    {
    //        deck = Shuffle(deck); //calling method
    //    }
    //    return deck;
    //}

    //TwentyOneGame game = new TwentyOneGame();
    //{
    //    game.Players = new List<string> { "Madi", "Porter", "Kindee" }; //calling properties of Game class
    //    game.ListPlayers(); //calling method from Game class
    //    game.Play();
    //    Console.ReadLine();
    //}

    
    //Game game = new TwentyOneGame(); // ex of polymorphism
}


