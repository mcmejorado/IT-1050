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

        public static int HeadCount;
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

             this.PrintNameAndAge();
             //this.GetFullName();

             SumOfAllAges += this.Age;
             HeadCount++;             
         }

         public void CollectDataSpouse()
         {

             string spouse = "y";
             bool keepAsking = true;

             while (keepAsking)
             {
                System.Console.Write("Do you have spouse y/n : ");
                spouse = System.Console.ReadLine().ToLower();
                if (spouse == "y" || spouse == "n")
                {
                    keepAsking = false;
                }
            }

             if (spouse == "y")
             {
                 this.Spouse = new Person();  
                 this.Spouse.Spouse = this; 

                 System.Console.Write("Enter Your Spouse's First Name   : ");
                 this.FirstName = System.Console.ReadLine();

                 System.Console.Write("Enter Your Spouse's Age          : ");
                 this.Age = int.Parse(System.Console.ReadLine());

                 this.PrintNameAndAge();
                 //this.GetFullName();

                 SumOfAllAges += this.Age;
                 HeadCount++;

                 System.Console.WriteLine("");                
             }
         } 

        //public string GetFullName(string name, string lastname, int age)
        public string GetFullName()
        {
            //return lastname +", " + name + " (" + age +")";
            return this.FirstName + ", " + this.LastName + " (" + this.Age + ")";
        }
  
        //public void PrintNameAndAge(string fullName)
        public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.GetFullName());
           
        }

        public static double GetAverageAge()
        {
            return (double)SumOfAllAges/(double)HeadCount;        
        }


    }
}
