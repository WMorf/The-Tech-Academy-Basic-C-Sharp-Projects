using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student" };

            sample.SayName();

            Console.ReadLine();
            sample.Quit();
        }
    }
}
