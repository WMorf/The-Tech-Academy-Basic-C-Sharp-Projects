using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step292_MethodObjects
{
    class Person
    {
        //Step 1 add firstname/lastname properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Step 2 void method printing full name
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}
