using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a list of at least 10 employees. At least two employees should have the first name “Joe”
            List<Employee> empList = new List<Employee>()
            {
                new Employee() {Id = 1, firstName = "Joe", lastName = "Clonesmith"},
                new Employee() {Id = 2, firstName = "Joe", lastName = "Clonesmith"},
                new Employee() {Id = 3, firstName = "Jim", lastName = "Clonesmith"},
                new Employee() {Id = 4, firstName = "James", lastName = "Clonesmith"},
                new Employee() {Id = 5, firstName = "John", lastName = "Clonesmith"},
                new Employee() {Id = 6, firstName = "Jack", lastName = "Clonesmith"},
                new Employee() {Id = 7, firstName = "Jesse", lastName = "Clonesmith"},
                new Employee() {Id = 8, firstName = "Jacob", lastName = "Clonesmith"},
                new Employee() {Id = 9, firstName = "Josh", lastName = "Clonesmith"},
                new Employee() {Id = 10, firstName = "Jude", lastName = "Clonesmith"}
            };

            List<Employee> joeList = new List<Employee>();


            // Using a foreach loop, create a new list of all employees with the first name “Joe”
            foreach (Employee employee in empList)
            {
                if (employee.firstName == "Joe")
                {
                    joeList.Add(employee);
                }
            }

            //Perform the same action again, but this time with a lambda expression.
            List<Employee> lambdaJoes = empList.Where(x => x.firstName == "Joe").ToList();

            //Using a lambda expression, make a list of all employees with an Id number greater than 5
            List<Employee> overFiveId = empList.Where(x => x.Id > 5).ToList();



            //Debug log to verify
            Console.WriteLine(" Debug \n");
            Console.WriteLine(" joeList");
            foreach (Employee x in joeList)
            {
                Console.WriteLine(" " + x.firstName + " " + x.lastName + " Id: " + x.Id);
            }

            Console.WriteLine("\n lambdaJoes");
            foreach (Employee x in lambdaJoes)
            {
                Console.WriteLine(" " + x.firstName + " " + x.lastName + " Id: " + x.Id);
            }

            Console.WriteLine("\n overFiveId");
            foreach (Employee x in overFiveId)
            {
                Console.WriteLine(" " + x.firstName + " " + x.lastName + " Id: " + x.Id);
            }

            Console.ReadLine();


        }

        
    }
}
