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
            //Step 5 Instantiate an Employee objecct
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student" };

            //Call superclass method
            sample.SayName();

            Console.ReadLine();
        }
    }
}
