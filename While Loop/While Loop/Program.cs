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

            Console.WriteLine("Guess the Letter");
            Console.WriteLine("Any Letter of the Alphabet");
            string letter = Console.ReadLine();
            bool isLetter = letter == "a";

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

            while (Countdown > 0)
            {
                if(Countdown > 0)
                {
                    Console.WriteLine(Countdown);
                    Countdown--;
                }
                
                if(Countdown <= 0)
                {
                    Console.WriteLine("Boom!");
                }
            }

            Console.ReadLine();
        }
    }
}
