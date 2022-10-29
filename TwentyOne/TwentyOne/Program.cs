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

            //Set Bank Balance
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much money did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer) Console.WriteLine("Please enter whole numbers only");
            }



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
                    try
                    {
                        game.Play();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("An error occured. Please contact your system Administrator.");
                        Console.ReadLine();
                        return;
                    }
                    
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
