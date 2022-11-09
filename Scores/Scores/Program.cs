using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            string path = @"C:\Users\techa\OneDrive\Desktop\Github\The-Tech-Academy-Basic-C-Sharp-Projects\Scores\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;

            Console.WriteLine("\n Student Scores: \n");
            foreach (string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\n Total of " + lines.Length + "student scores. \tAverage Score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
