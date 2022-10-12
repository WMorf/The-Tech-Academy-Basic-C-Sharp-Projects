using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate new ThisClass class
            ThisClass newClass = new ThisClass();

            try
            {
                //takes in, math, returns int
                Console.WriteLine(newClass.NewMethod(8));
                //takes decimal,math, returns int
                Console.WriteLine(newClass.NewMethod(6.5m));
                //takes string, tries to convert to int, math, returns int
                Console.WriteLine(newClass.NewMethod("5"));
            }
            //ensures proper input provided, prints error message if not
            catch(FormatException)
            {
                Console.WriteLine("Incorrect format given.");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
