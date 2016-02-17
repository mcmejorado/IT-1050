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
        //public Person Spouse = new Person();
        public string spouseName;
        public int spouseAge;

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

             System.Console.Write("Enter Your Spouse's First Name   : ");
             this.spouseName = System.Console.ReadLine();

             System.Console.Write("Enter Your Spouse's Age          : ");
             this.spouseAge = int.Parse(System.Console.ReadLine());
            
             System.Console.WriteLine("");
         } 

        public string GetFullName(string name, string lastname, int age)
        {
            return lastname +", " + name + "(" + age +")";
        }
  
        public void PrintNameAndAge(string fullName)
        {
            System.Console.Write(fullName);
           
        }

        public void GetAverageAge()
        {
            
        }


    }
}
