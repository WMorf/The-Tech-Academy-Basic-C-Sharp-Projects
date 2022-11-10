using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Employee : Person, IQuittable
    {
        //Create an Employee class with the following properties:
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + this.firstName + " " + this.lastName);
        }

        public void Quit()
        {
            Console.WriteLine("Goodbye");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}