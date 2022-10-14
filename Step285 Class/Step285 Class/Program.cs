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
            Console.WriteLine(newClass.output + "\n");

            //Call Step 4
            Console.WriteLine("Spaces from zero");
            Console.WriteLine("Pick a number, again");
            int number = Convert.ToInt32(Console.ReadLine());
            string overload = newClass.SpacesBetween(number, out int spaces);
            Console.WriteLine(overload + "\n");

            //Call Step 5
            Console.WriteLine("Spaces between 2 floats");
            Console.WriteLine("Pick the first float");
            float float1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Pick the second float");
            float float2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine(" Your numbers have a difference of " + newClass.SpacesBetween(float1, float2) + "\n");

            //Call Step 6
            Console.WriteLine("Add 257 to a number");
            Console.WriteLine("Pick a number one more time");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(number2 + " + 257 = " + MyClass.Add257(number2));
            Console.ReadLine();

        }
    }
}
