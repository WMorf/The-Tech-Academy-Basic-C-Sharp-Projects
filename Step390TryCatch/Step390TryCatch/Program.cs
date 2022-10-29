using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step390TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Step390 Try-Catch");

            try
            {
                Console.WriteLine("How old are you");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("Cannot use zero or below zero number");
                    throw new Exception();
                }
                else
                {
                    DateTime now = DateTime.Now;
                    now = now.AddYears(age * -1);
                    Console.WriteLine("You were born in " + now.Year);
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a whole number above zero next time. Goodbye!");
            }
            catch(Exception)
            {
                Console.WriteLine("An error has occured. Closing Program");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
