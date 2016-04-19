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
            Console.WriteLine("What is the name of the course: ");
            course.name = Console.ReadLine();
            Console.WriteLine("CRN number");
            course.CRN = Console.ReadLine();

            Console.WriteLine("How many students do you want: ");
            int numStudents = int.Parse(Console.ReadLine());

            for(int i = 0; i<numStudents; i++)
            {
   

            }

        }
    }
}
