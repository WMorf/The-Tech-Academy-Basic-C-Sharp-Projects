using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 2
            MyClass newClass = new MyClass();

            //Step 3 use method on user input and print result to screen
            Console.WriteLine("Pick a number to split in half!");
            int input = Convert.ToInt32(Console.ReadLine());
            newClass.MyMethod(input);
            Console.WriteLine(newClass.output);
            Console.ReadLine();

            //Call Step 4
            Console.WriteLine("Pick a number, again");
            int number = Convert.ToInt32(Console.ReadLine());
            string overload = newClass.SpaceFromZero(number);
            Console.WriteLine();
            Console.ReadLine();

            //Call Step 5
            Console.WriteLine("Pick another number");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number2 + " is a positive number:" + newClass.SpaceFromZero(number2));



            //Call Step 6
            Console.WriteLine("Pick a number one more time");
            int number3 = Convert.ToInt32(Console.ReadLine());

        }
    }
}
