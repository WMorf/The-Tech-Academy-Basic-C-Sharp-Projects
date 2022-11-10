using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Choose a number to do math operations on.");

            //takes input from user
            int input = Convert.ToInt32(Console.ReadLine());

            //prints returned input to console
            Console.WriteLine(MyClass.AddFive(input));

            Console.WriteLine(MyClass.TimesFive(input));

            Console.WriteLine(MyClass.DivideFive(input));

            Console.ReadLine();
        }
    }
}
