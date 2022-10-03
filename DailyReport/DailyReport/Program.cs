using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //Display Title
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //Blank Line
            Console.WriteLine("\n");

            //Ask your name and save it to a string
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            //Ask course name and save it to a string
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            //Ask page number and save it to an string
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            //Using Casting, the string is converted to an int
            int pgNum = Convert.ToInt32(pageNumber);

            //Ask if help required saving response to a sring
            Console.WriteLine("Do you need help with anything? Please answer “True” or “False.");
            string needHelp = Console.ReadLine();
            //Using Casting, the string is converted to a bool
            bool help = Convert.ToBoolean(needHelp);

            //Ask for positive experiences and save to a string
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveNote = Console.ReadLine();

            //Ask for feedback and save result to a string
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            //Ask how many hours studied and save to a string
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            //Using Casting, the string is converted to an int
            int sHrs = Convert.ToInt32(studyHours);

            //Display Closing
            Console.WriteLine("\n");
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.");
            Console.WriteLine("Have a great day!");

            //Debug
            //Console.WriteLine("\n");
            //Console.WriteLine(yourName.GetType());
            //Console.WriteLine(courseName.GetType());
            //Console.WriteLine(pgNum.GetType());
            //Console.WriteLine(help.GetType());
            //Console.WriteLine(positiveNote.GetType());
            //Console.WriteLine(feedback.GetType());
            //Console.WriteLine(sHrs.GetType());

            //Keeps window from closing so console can be read.
            Console.Read();

        }
    }
}
