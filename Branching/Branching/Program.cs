using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main()
        {

            float fPkgWeight;
            float fPkgWidth;
            float fPkgHeight;
            float fPkgLength;
            float fPkgDimensions;
            float fTotal;

            //Check if package is under 50 pounds
            void PKGWeight()
            {
                Console.WriteLine("Please enter package weight in pounds");
                string strPkgWeight = Console.ReadLine();
                fPkgWeight = Convert.ToSingle(strPkgWeight); // Convert input to float
                
                if(fPkgWeight > 50f)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.WriteLine("Try a different package");
                    PKGWeight();
                }
                else
                {
                    Console.WriteLine("The Package is within acceptable weight");
                }
            }

            // Calculates Package imensions and checks that it doesnt exceed 100
            void PKGDimensions()
            {
                Console.WriteLine("Package Dimensions \n");

                Console.WriteLine("Please enter package width");
                string strPkgWidth = Console.ReadLine();
                fPkgWidth = Convert.ToSingle(strPkgWidth); // Convert input to float

                Console.WriteLine("Please enter package height");
                string strPkgHeight = Console.ReadLine();
                fPkgHeight = Convert.ToSingle(strPkgHeight); // Convert input to float

                Console.WriteLine("Please enter package Length");
                string strPkgLength = Console.ReadLine();
                fPkgLength = Convert.ToSingle(strPkgLength); // Convert input to float

                fPkgDimensions = fPkgWidth + fPkgHeight + fPkgLength;
                if(fPkgDimensions > 100f)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            void Total()
            {
                float fPkgProduct = (fPkgHeight * fPkgWidth * fPkgLength) * fPkgWeight;
                fTotal = fPkgProduct / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + fTotal);
            }

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below. \n");
            PKGWeight();
            PKGDimensions();
            Total();
            Console.ReadLine();






        }
    }
}
