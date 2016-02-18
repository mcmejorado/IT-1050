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
       //     string FullNameP1 = P1.GetFullName(P1.FirstName, P1.LastName, P1.Age);          
            P1.CollectDataSpouse();
     //       string FullNameSpouseP1 = P1.GetFullName(P1.FirstName, P1.LastName, P1.Age);  
            
            P2.CollectData("p2");                             
     //       string FullNameP2 = P2.GetFullName(P2.FirstName, P2.LastName, P2.Age);            
            P2.CollectDataSpouse();
     //       string FullNameSpouseP2 = P2.GetFullName(P2.FirstName, P2.LastName, P2.Age);            

            System.Console.WriteLine("");
            System.Console.WriteLine("[Printing Results]");
            System.Console.WriteLine("");           
            
    /*        P1.PrintNameAndAge(FullNameP1);
            P1.PrintNameAndAge(FullNameSpouseP1);
            P2.PrintNameAndAge(FullNameP2);
            P1.PrintNameAndAge(FullNameSpouseP2); */
            
            System.Console.WriteLine("Average Age: " + Person.GetAverageAge());                            
            System.Console.ReadKey();

        }
    }
}
