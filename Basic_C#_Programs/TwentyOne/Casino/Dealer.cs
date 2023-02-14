using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Casino
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)//taking in hand as an input parameter
        {
            Hand.Add(Deck.Cards.First()); //adding first item in deck to hand
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //print to console,
            Deck.Cards.RemoveAt(0); //removing item from deck
            Console.ReadLine();
        }
    }
}
