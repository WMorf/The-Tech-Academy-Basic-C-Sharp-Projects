using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }

        //Step 2 Employee class inherit that interface and implement the Quit() method
        public void Quit()
        {
            Console.WriteLine("Goodbye");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
