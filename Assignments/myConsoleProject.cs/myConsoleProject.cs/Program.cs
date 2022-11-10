using System;


namespace myConsoleProject.cs
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hello, " + name + "!");
            //Console.WriteLine("Look at this quote \"");
            //Console.Read();

            int num1 = 3;
            int num2 = 6;
            int sum = num1 + num2;
            Console.WriteLine(sum);


            int diff = num1 - num2;
            Console.WriteLine(diff);

            int product = num1 * num2;
            Console.WriteLine(product);

            int quotient = num1 / num2;
            Console.WriteLine(quotient);

            int remainder = num1 % num2;
            Console.WriteLine(remainder);
            Console.Read();
        }
    }
}
