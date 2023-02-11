using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Player<Card> player = new Player<Card>();

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled {0}");
            Console.ReadLine();

            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game); //polymorphism is the ability of a class
            //                 //to morph into its inheriting class

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


