using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            string getIn = "y";
            while (getIn == "y" || getIn == "Y")
            {
                System.Console.Clear();
                Questions.printHeader();

                Course course = new Course();
                course.AskName();
                course.AskCRN();

                int numStudents = Questions.AskForInteger("How many students do you want: ");
                course.SetStudents(numStudents);
                course.PrintCourse();

                System.Console.WriteLine();
                getIn = Questions.AskForString("Do you want to start over (y/n)").ToLower();
                
            }
            System.Console.WriteLine("Press a key to continue...");
            System.Console.ReadKey();
        }


    }
}





