using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Instructor
    {
        private string name;        
        private string courseName;

        public Instructor(string name, string courseName )
        {
            this.name = name;            
            this.courseName = courseName;
        }

        public void SetStudentGrade(Student s1, int grade)
        {
            s1.SetGrade(grade);
        }

        public void PrintTeacher()
        {
            System.Console.WriteLine("          " + this.name + Utilities.Spaces(this.name) + this.courseName);
        }

    }
}
