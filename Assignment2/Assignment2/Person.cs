using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static int HeadCounter;
        public static double SumOfAllAges;

         public void CollectData(string personNumber)
         {
             System.Console.WriteLine("");
             System.Console.WriteLine("[ Enter information for " + personNumber + " ]");
             System.Console.WriteLine("");

             System.Console.Write("Enter Your First Name            : "); 
             this.FirstName = System.Console.ReadLine();
             
             System.Console.Write("Enter Your Last Name             : ");
             this.LastName = System.Console.ReadLine();
             
             System.Console.Write("Enter Your Age                   : ");             
             this.Age = int.Parse(System.Console.ReadLine());          
            
             SumOfAllAges += this.Age;
             HeadCounter++;             
         }

         public void CollectDataSpouse()
         {
             if (Utilities.askSpouse() == "y")
             {
                 Spouse = new Person();
                 
                 System.Console.Write("Enter Your Spouse's First Name   : ");                                  
                 Spouse.FirstName = System.Console.ReadLine();
                 Spouse.LastName = this.LastName;
                 
                 System.Console.Write("Enter Your Spouse's Age          : ");                 
                 Spouse.Age = int.Parse(System.Console.ReadLine());
                 
                 SumOfAllAges += Spouse.Age;
                 HeadCounter++;

                 this.Spouse.Spouse = this;
             }
         } 


        public string GetFullName()
        {
            return this.FirstName + ", " + this.LastName + " (" + this.Age + ")";
        }
  
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
           
        }

        public static double GetAverageAge()
        {
            return (double)SumOfAllAges/(double)HeadCounter;        
        }


    }
}
