using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program \n");

            // Person 1
            Console.WriteLine("Person1");
            Console.WriteLine("Input Hourly Rate");
            string person1hr = Console.ReadLine();
            Console.WriteLine("Input Hours Worked per Week");
            string person1wrk = Console.ReadLine();

            //Convert inputs to floats
            float p1hr = Convert.ToSingle(person1hr);
            float p1wk = Convert.ToSingle(person1wrk);
            //Calculate rate * hrs worked * 52 weeks in a year
            float person1all = p1hr * p1wk * 52;
            Console.WriteLine("Person 1 makes " + person1all + "\n");


            // Person 2
            Console.WriteLine("Person2");
            Console.WriteLine("Input Hourly Rate");
            string person2hr = Console.ReadLine();
            Console.WriteLine("Input Hours Worked per Week");
            string person2wrk = Console.ReadLine();

            //Convert inputs to floats
            float p2hr = Convert.ToSingle(person2hr);
            float p2wk = Convert.ToSingle(person2wrk);
            //Calculate rate * hrs worked * 52 weeks in a year
            float person2all = p2hr * p2wk * 52;
            Console.WriteLine("Person 2 makes " + person2all + "\n");


            Console.WriteLine("Does Person 1 make more than Person 2?");
            Console.ReadLine();
            //Check if person 1 makes more than person 2
            bool makeMore = person1all > person2all;
            Console.WriteLine(makeMore);

            //end
            Console.ReadLine();
            Console.WriteLine("End Program");

            Console.ReadLine();
            Console.WriteLine("Are you still here?");

            Console.ReadLine();
            Console.WriteLine("The program is over, you can leave now.");

            Console.ReadLine();
            Console.WriteLine("Go home.");
            Console.ReadLine();

        }
    }
}
