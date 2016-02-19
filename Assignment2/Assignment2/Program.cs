using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Person p2 = new Person();

            p1.CollectData("p1");      
            p1.CollectDataSpouse();                 
            p2.CollectData("p2");                                  
            p2.CollectDataSpouse();

            Utilities.printHeader();
            
            p1.PrintNameAndAge();
            if (p1.Spouse != null) { p1.Spouse.PrintNameAndAge(); }            
            p2.PrintNameAndAge();
            if (p2.Spouse != null) { p2.Spouse.PrintNameAndAge(); }

            System.Console.WriteLine("");
            System.Console.WriteLine("Average Age: " + Person.GetAverageAge());                            
            System.Console.ReadKey();

        }
    }
}
