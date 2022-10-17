using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302AbstractClass
{
    class Employee : Person
    {
        public int Id { get; set; }

        //Step 4 Implement SayName method inside of Employee
        public override void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}

