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

            Course course = new Course();
            course.AskName();
            course.AskCRN();

            int numStudents = Questions.AskForInteger("How many students do you want: ");
            course.SetStudents(numStudents);
            course.PrintCourse();
            System.Console.WriteLine("Press a key to continue...");
            System.Console.ReadKey();

        }

        
    }
}





