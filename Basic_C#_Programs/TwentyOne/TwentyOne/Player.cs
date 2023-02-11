﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivleyPlaying { get; set; }

        public static Game operator+ (Game game, Player player) //Game and Player are what's being added together, and it's returning a game
        {   //overloading the + operator, taking Game and Player
            game.Players.Add(player);  //adding Game and Player together
            return game;               //returning the effected class(game)
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }
}