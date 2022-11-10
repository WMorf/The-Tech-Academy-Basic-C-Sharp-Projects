using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main()
        {
            bool validInput = false;
            while (!validInput)
                //Wrap the above statement in a try/catch block
                try
                {
                    //Prompt the user to enter the current day of the week.
                    Console.WriteLine("Please enter the current day of the week. example: Monday");
                    string input = Console.ReadLine();

                    //Assign the value to a variable of that enum data type you just created.
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                    Console.WriteLine("Have a nice " + day);
                    validInput = true;
                    Console.ReadLine();
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week.\n");
                }


        }

        //Create enum for days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
