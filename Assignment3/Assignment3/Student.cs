using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
        private string name;        
        private string teacher;
        private int grade;

        public Student(string name, string teacher, int grade)
        {
            this.name = name;
            this.teacher = teacher;
            this.grade = grade;
        }

        public void SetGrade(int grade)
        {
            this.grade = grade;
        }

        public void Print()
        {
            string space = "     ";
            System.Console.Write("Student: " + this.name + space);
            System.Console.Write("Grade:" + this.grade + space);
            //.Print();
         
            System.Console.WriteLine("Teacher: " + this.teacher);            
        }


    }
}
