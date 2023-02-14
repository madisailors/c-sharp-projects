﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Casino
{
    public class Player
    {
        public Player(string name, int beginningBalance)
        {
            Hand = new List<Card>();
            Balance = beginningBalance;
            Name = name;
        }

        private List<Card> _hand = new List<Card>();

        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivleyPlaying { get; set; }
        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough to place a bet that size");
                return false;
            }
            else
            {
                Balance -= amount; // balance = balance - amount
                return true;
            }
        }

        public static Game operator +(Game game, Player player) //Game and Player are what's being added together, and it's returning a game
        {   //overloading the + operator, taking Game and Player
            game.Players.Add(player);  //adding Game and Player together
            return game;               //returning the effected class(game)
        }

        public static Game operator -(Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}
