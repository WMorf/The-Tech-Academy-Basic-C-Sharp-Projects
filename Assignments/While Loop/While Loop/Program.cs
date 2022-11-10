using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main()
        {
            //Choose a letter game
            Console.WriteLine("Guess the Letter");
            Console.WriteLine("Any Letter of the Alphabet");
            string letter = Console.ReadLine();
            bool isLetter = letter == "a";

            //runs while loop at least once
            do
            {

                switch (letter)
                {
                    case "a":

                        isLetter = true;

                        break;

                    default:

                        Console.WriteLine("You are wrong");
                        Console.WriteLine("Guess Again");
                        letter = Console.ReadLine();

                        break;

                }
            }
            while (!isLetter);


            int Countdown = 10;

            //While loop runs until it gets to one then...
            while (Countdown > 0)
            {
                if(Countdown > 0)
                {
                    Console.WriteLine(Countdown);
                    Countdown--;
                }
                
                if(Countdown <= 0)
                {
                    // explosion
                    Console.WriteLine("Boom!");
                }
            }

            //keep console from closing
            Console.ReadLine();
        }
    }
}
