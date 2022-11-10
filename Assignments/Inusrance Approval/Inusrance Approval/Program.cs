using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inusrance_Approval
{
    class Program
    {
        //Your application must ask these questions:

        //What is your age?

        //Have you ever had a DUI?

        //How many speeding tickets do you have?

        static void Main()
        {
            //bools used to determin validity of insurance
            bool bDUI = false;
            bool valid = false;

            //Method for determining if applicant has dui
            void DUI()
            {
                Console.WriteLine("Have you ever had a DUI? Y/N");
                string strDUI = Console.ReadLine();

                //Changes input to lowercase to avoid errors
                strDUI = strDUI.ToLower();

                if (strDUI == "y")
                {
                    bDUI = true;
                }
                else if (strDUI == "n")
                {
                    bDUI = false;
                }
                else
                {
                    Console.WriteLine("Please write either Y or N");
                    DUI();
                }
            }

            //Gather Input from user

            Console.WriteLine("What is your age?");
            string strAge = Console.ReadLine();
            int intAge = Convert.ToInt32(strAge);
            //Console.WriteLine(intAge);

            //calls DUI function
            DUI();
            //Console.WriteLine(bDUI);

            Console.WriteLine("How many speeding tickes do you have?");
            string strTickets = Console.ReadLine();
            int intTickets = Convert.ToInt32(strTickets);
            //Console.WriteLine(intTickets);

            //Logic to determine validity. Over 15, No DUIS, less than 3 tickets
            if(intAge > 15 && !bDUI && intTickets < 3)
            {
                valid = true;
                Console.WriteLine("You are valid to be inusured");
            }
            else
            {
                valid = false;
                Console.WriteLine("You are not valid to be inusured");
            }

            Console.ReadLine();


        }
    }
}
