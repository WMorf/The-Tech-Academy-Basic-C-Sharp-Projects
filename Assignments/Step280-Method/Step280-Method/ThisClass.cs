using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step280_Method
{
    class ThisClass
    {
        //takes in an int and an optional int, does math, returns answer
        public int TakesTwo(int input, int optInput = 0)
        {
            int answer = input + optInput + 5;
            return answer;
        }
    }
}
