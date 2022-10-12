using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class ThisClass
    {
        //takes in, math, returns int
        public int NewMethod(int input, int option = 1)
        {
            int answer = input * option * 5;
            return answer;
        }

        //takes decimal,math, returns int
        public int NewMethod(decimal input)
        {
            int answer = Convert.ToInt32(input) - 2;
            return answer;
        }

        //takes string, tries to convert to int, math, returns int
        public int NewMethod(string input)
        {
            int answer = Convert.ToInt32(input) + 2;
            return answer;
        }
    }
}
