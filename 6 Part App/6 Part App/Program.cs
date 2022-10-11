using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Part_App
{
    class Program
    {
        static void Main()
        {

            //Part 1

            //A one-dimensional array of strings.
            string[] jobs = { "Take out trash ", "Do the Dishes ", "Scrape Gum ", "Sweep lobby " };
            Console.WriteLine("Add a word or phrase to work tasks");
            string addon = Console.ReadLine();

            //Loop through array, adding the user input to each index
            for( int i = 0; i < jobs.Length; i++)
            {
                jobs[i] = jobs[i] + addon;
            }

            //Loop through and print ammended entries
            Console.WriteLine("foreach (string job in jobs)");
            foreach (string job in jobs)
            {
                Console.WriteLine(job);
            }

            Console.WriteLine("\n");

            //Part 2

            //Int to be counted down
            int countdown = 20;
            Console.WriteLine("int countdown = 20 \n");

            Console.WriteLine("while(countdown > 0)");
            Console.WriteLine("countdown--");
            while (countdown > 0)
            {
                Console.WriteLine(countdown);

                //Added to stop loop from being forever true
                countdown--;
            }

            Console.WriteLine("\n");

            //Part 3

            //loop using less than '<' operator
            Console.WriteLine("while (countdown < 30)");
            Console.WriteLine("countdown++");
            while (countdown < 30)
            {
                countdown++;
                Console.WriteLine(countdown);
            }

            Console.WriteLine("\n");

            //loop using less than or equal to
            Console.WriteLine("while (countdown <= 40)");
            Console.WriteLine("countdown++");
            while (countdown <= 40)
            {
                Console.WriteLine(countdown);
                countdown++;
            }

            Console.WriteLine("\n");


            //Part 4

            //List of unique strings
            List<string> myList = new List<string> { "This", "is", "a", "unique", "list"};

            Console.WriteLine("Enter Search Parameters");
            string search = Console.ReadLine();

            //iterates through myList checking if it is contained within
            for( int i = 0; i <  myList.Count; i++)
            {
                if (myList[i] == search)
                {
                    Console.WriteLine("The item " + myList[i] + " is at the index [" + i + "]");
                    break;
                }
                //If not present, message printed and loop exited
                else if(!myList.Contains(search))
                {
                    Console.WriteLine("The item " + search + " is not in myList");
                    break;
                }
            }

            Console.WriteLine("\n");

            //Part 5

            //List of strings with duplicate
            List<string> myOtherList = new List<string> { "I", "am", "seeing", "double", "double" };

            Console.WriteLine("Enter Search Parameters");
            string search2 = Console.ReadLine();

            //iterates through myOtherList checking if it is contained within
            for (int i = 0; i < myOtherList.Count; i++)
            {
                if (myOtherList[i] == search2)
                {
                    Console.WriteLine("The item " + myOtherList[i] + " is at the index [" + i + "]");
                }
                //If not present, message printed and loop exited
                else if (!myOtherList.Contains(search2))
                {
                    Console.WriteLine("The item " + search2 + " is not in myOtherList");
                    break;
                }
            }

            Console.WriteLine("\n");

            //Part 6

            //List with duplicates
            List<string> thisList = new List<string> { "War", "Huh", "What", "Good For", "War" };

            List<string> readList = new List<string> {};
            foreach(string item in thisList)
            {
                //If item has been read before this will print that it is a duplicate
                if (readList.Contains(item))
                {
                    Console.WriteLine("this item is a duplicate");
                    readList.Add(item);
                }
                //If not, item is added to the readList
                else
                {
                    Console.WriteLine("this item is a unique");
                    readList.Add(item);
                }

            }

            Console.ReadLine();
        }
    }
}
