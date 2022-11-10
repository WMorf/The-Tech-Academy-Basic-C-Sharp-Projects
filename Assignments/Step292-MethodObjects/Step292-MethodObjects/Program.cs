using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step292_MethodObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 4 Instantiate an Employee objecct
            Employee sample = new Employee() { FirstName = "Sample", LastName = "Student" };

            //Call superclass method
            sample.SayName();

            Console.ReadLine();
        }
    }
}
