using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_281___Method
{
    class Program
    {
        static void Main(string[] args)
        {
            ThisClass NewClass = new ThisClass();
            //feed two ints into method
            NewClass.TakesTwo(5, 6);
            //feed 2 ints into method specifying parameter names
            NewClass.TakesTwo(int1: 4, int2: 10);

            Console.ReadLine();
        }
    }
}
