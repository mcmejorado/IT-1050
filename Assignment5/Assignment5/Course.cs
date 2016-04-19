using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Course
    {
        public string CourseName;
        public int CRN;
        public Student[] Students;

        private void AskName()
        {
            CourseName = Questions.AskForString("What is the name of the course"); 
        }

        private void AskCRN()
        {
            CRN = Questions.AskForInteger("What is the CRN of the course");
        }
           

    }
}
