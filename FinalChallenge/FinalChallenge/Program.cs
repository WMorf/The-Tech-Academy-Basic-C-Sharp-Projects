using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "John Rambo" }; //Creates one student

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.WriteLine(stud.StudentName + " was added to the database.");
            }
        }
    }
}
