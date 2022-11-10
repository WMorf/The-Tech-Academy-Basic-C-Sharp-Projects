using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee : Person, IQuittable
    {
        //Step 1 Create an Employee class with Id, FirstName and LastName properties. 
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Step 2 overload the “==” operator and it's pair !=
        public static bool operator == (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator != (Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }

        public override void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }

        public void Quit()
        {
            Console.WriteLine("Goodbye");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}