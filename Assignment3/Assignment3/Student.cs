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
        private Instructor teacher;
        private int grade;

        public Student(string name, Instructor teacher, int grade)
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
            System.Console.Write("     Student: " + this.name+  "     Grade: " + this.grade);
            teacher.PrintTeacher();                   
        }


    }
}
