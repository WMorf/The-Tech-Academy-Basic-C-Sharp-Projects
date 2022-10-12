using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class MyClass
    {
        // takes input, adds 5 and returns sum
        public static int AddFive(int input)
        {
            int sum = input + 5;
            return sum;
        }

        //takes input, multiplies by 5, returns product
        public static int TimesFive(int input)
        {
            int product = input * 5;
            return product;
        }

        //takes input, divides by 5, returns quotient
        public static int DivideFive(int input)
        {
            int q = input / 5;
            return q;
        }
    }
}
