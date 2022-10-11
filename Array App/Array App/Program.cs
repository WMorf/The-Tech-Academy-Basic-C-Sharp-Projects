using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_App
{
    class Program
    {
        static void Main()
        {
            //Create and populate 2 arrays. 1 with strings and 1 with ints
            string[] words = { "This", "is", "the", "worst!" };
            int[] nums = { 0, 1, 2, 3,};
           List<string> notes = new List<string> { "Doe", "Re", "Mi" };


            //Get Index for words and print to screen if within range of array
            Console.WriteLine("Please choose an index for words (0-3)");
            int wordIndex = Convert.ToInt32(Console.ReadLine());

            if (wordIndex < words.Length)
            {
                Console.WriteLine(words[wordIndex]);
            }else
            {
                Console.WriteLine("Please Choose within range"); //If number for index exceeds array
            }

            //Get Index for nums and print to screen if within range of array
            Console.WriteLine("Please choose an index for nums (0-3)");
            int numIndex = Convert.ToInt32(Console.ReadLine();

            if (numIndex < nums.Length)
            {
                Console.WriteLine(nums[numIndex]);
            }
            else
            {
                Console.WriteLine("Please Choose within range");
            }

            //Get Index for notes and print to screen if within range of list
            Console.WriteLine("Please choose an index for notes (0-2)");
            int noteIndex = Convert.ToInt32(Console.ReadLine();

            if (noteIndex < notes.Count)
            {
                Console.WriteLine(notes[noteIndex]);
            }
            else
            {
                Console.WriteLine("Please Choose within range");
            }

            //keep program from closing
            Console.Read();



        }
    }
}
