using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Utilities
    {

        public static void printHeader()
        {
            System.Console.WriteLine("     Student Name       Grade           Teacher Name       Course Name");
        }

        public static void printFootNote()
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }

        public static string Spaces(string chain)
        {
            string spaces = "";
            int chainSpaces = chain.Length;
            int numSpaces = 18 - chainSpaces;
            for (int i = 0; i < numSpaces; i++)
            {
                spaces = spaces + " ";
            }
            return (spaces);
        }
    }
}
