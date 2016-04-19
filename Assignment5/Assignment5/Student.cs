using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Student
    {
        private string Name;
        private string SNumber;

        public void SetName(string Name)
        {
            this.Name = Name;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetNumber(string SNumber)
        {
            this.SNumber = SNumber;
        }

        public string GetSNumber()
        {
            return SNumber;
        }

        public void Print()
        {
            System.Console.WriteLine("[" + this.GetSNumber() + "] " + this.GetName());
        }

    }
}
