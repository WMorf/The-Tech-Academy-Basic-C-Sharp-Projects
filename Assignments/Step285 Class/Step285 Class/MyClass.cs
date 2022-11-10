using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step285_Class
{
    class MyClass
    {
        //Step 1 Create a void method 
        public int output { get; set; }
        public void MyMethod(int input)
        {
            output = input / 2;
        }

        //Step 4 method with output parameters
        public string SpacesBetween(int input, out int spaces)
        {
            spaces = 0 + input;
            string howMany = "Your number is " + spaces + " from zero";
            return howMany;
        }

        //Step 5 Overload method
        public float SpacesBetween(float input1, float input2)
        {
            float spaces = input1 - input2;
            return spaces;
        }

        //Step6 Declare a class to be static

        public static int Add257(int input)
        {
            int  sum = input + 257;
            return sum;
        }


    }
}
