using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step280_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ThisClass NewClass = new ThisClass();
            Console.WriteLine("Choose numbers to add 5 to \n");

            try
            {
                //get input from user
                Console.WriteLine("Please enter the first number");
                int input = Convert.ToInt32(Console.ReadLine());

                //get optional input from user
                Console.WriteLine("Please enter the second number. (NOT REQUIRED)");
                string strinput = Console.ReadLine();

                //if the second input is not blank, run method with both inputs entered
                if (strinput != "")
                {
                    int optInput = Convert.ToInt32(strinput);
                    Console.WriteLine(NewClass.TakesTwo(input, optInput));
                }
                //if second input empty, run method without second input
                else
                {
                    Console.WriteLine(NewClass.TakesTwo(input));
                }

            }
            catch(FormatException)
            {
                Console.WriteLine("Incorrect Format provided");
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
