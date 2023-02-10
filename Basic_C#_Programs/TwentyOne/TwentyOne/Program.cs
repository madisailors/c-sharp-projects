﻿using System;
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
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled {0}");
            Console.ReadLine();

        }

        
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


