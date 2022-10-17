using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302AbstractClass
{
    public abstract  class Person
    {
        //Step 1 add firstname/lastname properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Step 2 Give method SayName();
        public abstract void SayName();
    }
}

