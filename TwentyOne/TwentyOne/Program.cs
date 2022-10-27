using System;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";



            //Greet Player
            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            //Begin Game
            Console.WriteLine("Hello, {0}. Would you like to play a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                //Globally Uniquw Identifier
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Casino\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }

                //Polymorphism so we can use overloaded operators
                Game game = new TwentyOneGame();

                //Keep game going while player is active, add them to the game. Remove when while loop ends
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now...");

            //Pause Console
            Console.Read();
        }
    }
}
