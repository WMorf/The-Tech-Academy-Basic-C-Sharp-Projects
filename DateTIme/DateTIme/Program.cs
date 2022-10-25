using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTIme
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the current date and time to the console.
            Console.WriteLine(DateTime.Now);

            //Ask the user for a number.
            Console.WriteLine("Input a whole number");
            int input = Convert.ToInt32(Console.ReadLine());

            //Print to the console the exact time it will be in "input" hours
            DateTime thisIsNow = DateTime.Now;
            DateTime fromNow = thisIsNow.AddHours(input);
            Console.WriteLine("The time {0} hours from now is " + fromNow, input);

            Console.Read();
        }
    }
}
