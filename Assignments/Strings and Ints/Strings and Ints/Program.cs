using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Ints
{
    class Program
    {
        static void Main(string[] args)
        {
            //List on ints
            List<int> nums = new List<int> { 10, 20, 30, 40, 50 };
            Console.WriteLine("Number List");
            Console.WriteLine(nums[0] + " " + nums[1] + " " + nums[2] + " " + nums[3] + " " + nums[4]);

            //Code block to try
            try
            {
                Console.WriteLine("Choose a number to divide each number in list by");
                int divide = Convert.ToInt32(Console.ReadLine());

                //iterates through num list, dividing each index by the user input value
                for (int i = 0; i < nums.Count; i++)
                {
                    int q = nums[i] / divide;
                    //prints the equation
                    Console.WriteLine("\n" +  nums[i] + " divided by " + divide + " = " + q);
                }
            }
            //In case of format error such as string inoput
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number \n");
            }
            //In case zero is inout by user to divide
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero\n");
            }
            //all else
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //will always run after try/catch
            finally
            {
                Console.WriteLine("Emerged from Try/Catch Block");
                Console.ReadLine();
            }

        }
    }
}
