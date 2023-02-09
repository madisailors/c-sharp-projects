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
            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck: deck, out timesShuffled, times: 3); //deck: & times: aren't required, but help w readability

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled {0}", timesShuffled);
            Console.ReadLine();

        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0; //defining variable
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;   //adding one(1) on each loop
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            
            return deck;
        }

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //     for (int i = 0; i < times; i++) //iterating through parameter times until int input is reached
        //    {
        //        deck = Shuffle(deck); //calling method
        //    }
        //    return deck;
        //}
    }

}
