using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Utilities
    {
        public static void printHeader()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("[ Printing Results ]");
            System.Console.WriteLine("");
        }

        public static string askSpouse()
        {
            string spouse = "y";
            bool keepAsking = true;
            while (keepAsking)
            {
                System.Console.Write("Are you married y/n : ");
                spouse = System.Console.ReadLine().ToLower();
                if (spouse == "y" || spouse == "n")
                {
                    keepAsking = false;
                }
            }
            return spouse;
        }


    }
}
