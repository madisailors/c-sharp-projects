using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Casino1;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel & Casino. Start by telling me your name. ");
            string playerName = Console.ReadLine();

            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter numeric digits only, no decimals.");
            }

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya" )
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\madis\logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivleyPlaying = true;
                while (player.isActivleyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; // void methods return no output, so this ends the program
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error has occured, please contact your system administrator");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return;
                    }
                }
                game -= player;
                Console.WriteLine("Thank you for playing, {0}", playerName);
            }
            Console.WriteLine("Feel free to look around the casino, bye for now!");
            Console.Read();
        }
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=TwentyOneGame;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                    TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES
                                   (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
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


