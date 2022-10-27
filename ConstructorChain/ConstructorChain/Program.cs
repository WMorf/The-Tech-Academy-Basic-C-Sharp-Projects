using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name = "Bob";
            var HP = 5; //Health Points yo

            Person person1 = new Person();
            Person person2 = new Person(name);
            Person person3 = new Person(name, HP);
            Console.ReadLine();
        }
    }
}
