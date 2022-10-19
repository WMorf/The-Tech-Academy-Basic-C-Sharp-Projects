using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main()
        {
            //Use overloaded operator
            Employee employee1 = new Employee() { Id = 1 };
            Employee employee2 = new Employee() { Id = 2 };

            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();

            //Employee sample = new Employee() { FirstName = "Sample", LastName = "Student" };

            //sample.SayName();

            //Console.ReadLine();
            //sample.Quit();

            //IQuittable employee = new Employee();
            //employee.Quit();
        }
    }
}

