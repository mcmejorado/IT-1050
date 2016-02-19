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

            Person P1 = new Person();
            Person P2 = new Person();

            P1.CollectData("p1");      
            P1.CollectDataSpouse();                 
            P2.CollectData("p2");                                  
            P2.CollectDataSpouse();
     
            System.Console.WriteLine("");
            System.Console.WriteLine("[Printing Results]");
            System.Console.WriteLine("");
            
            P1.PrintNameAndAge();
            P1.Spouse.PrintNameAndAge();
            P2.PrintNameAndAge();
            P2.Spouse.PrintNameAndAge();
            
            System.Console.WriteLine("Average Age: " + Person.GetAverageAge());                            
            System.Console.ReadKey();

        }
    }
}
