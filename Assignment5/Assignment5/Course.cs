using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Course
    {
        private string CourseName;
        private int CRN;
        private Student[] Students;

        public void AskName()
        {
            CourseName = Questions.AskForString("What is the name of the course"); 
        }

        public void AskCRN()
        {
            CRN = Questions.AskForInteger("What is the CRN of the course");
        }

        public void SetStudents(int numStudents)
        {
            Console.WriteLine();
            Students = new Student[numStudents];
            for (int i = 0; i < numStudents; i++)
            {
                Students[i] = new Student();
                Students[i].SetNumber(Questions.AskForString("Student Number"));
                Students[i].SetName(Questions.AskForString("Student Name"));
            }
        }

        public void PrintCourse()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("      CRN" + "        Course Name");
            System.Console.WriteLine("     [" + this.CRN + "]  " + this.CourseName);
            System.Console.WriteLine();
            System.Console.WriteLine("      ==== Students ====");
            System.Console.WriteLine();
            foreach (Student student in Students)
            {
                student.Print();
            }
        }
    }
}
