using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Questions
    {
        public static string AskForString(string prompt)
        {
            System.Console.Write("     " + prompt.PadRight(35) + "=> ");
            return System.Console.ReadLine();
        }

        public static int AskForInteger(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }

        public static void printHeader()
        {
            System.Console.WriteLine("              ==== Creating a Course ====");
        }
    }
}
