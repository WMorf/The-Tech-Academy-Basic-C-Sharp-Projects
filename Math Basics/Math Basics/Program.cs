using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Basics
{
    class Program
    {
        static void Main()
        {
            //
            Console.WriteLine("Multiply by 50");
            string by50 = Console.ReadLine();
            int b50 = Convert.ToInt32(by50);
            int product = b50 * 50;
            Console.WriteLine(product);

            //
            Console.WriteLine("Add 25");
            string add25 = Console.ReadLine();
            int a25 = Convert.ToInt32(add25);
            int sum = a25 + 25;
            Console.WriteLine(sum);

            //
            Console.WriteLine("Divide by 12.5");
            string divby12half = Console.ReadLine();
            float div12 = Convert.ToSingle(divby12half);
            float quotient = div12 / 12.5f;
            Console.WriteLine(quotient);

            //
            Console.WriteLine("Greater than 50?");
            string greater50 = Console.ReadLine();
            int g50 = Convert.ToInt32(greater50);
            bool greater = g50 > 50;
            Console.WriteLine(greater);

            //
            Console.WriteLine("Divide by 7 and give remainder");
            string div7remain = Console.ReadLine();
            float div7 = Convert.ToSingle(div7remain);
            float remainder = div7 % 7;
            Console.WriteLine(remainder);

            //
            Console.Read();
        }
    }
}
