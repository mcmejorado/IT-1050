using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen = true;
            bool canVote = true;
            int heightFeet;
            double heighInches;
            double totalHeightCM;

            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your laste name? ");
            lastName = System.Console.ReadLine();

            fullName = firstName + " " + middleInitial + ". " + lastName;

            System.Console.Write("What is your height in feet? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches beyond your base height in feet to add to your height? ");
            heighInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = heightFeet * 12;
            totalHeightCM += heighInches;
            totalHeightCM *= 2.54;

            System.Console.Write("How old are you? ");
            age = int.Parse(System.Console.ReadLine());

            bool keepAsking = true;
            string citizen;
            while (keepAsking == true) {
              System.Console.Write("Are you American Citizen ? ");
              citizen = System.Console.ReadLine();
              citizen = citizen.ToLower();
              if (citizen == "true" || citizen == "t" || citizen == "y" || citizen == "yes") {
                  isCitizen = true;
                  keepAsking = false;
              } 
              if (citizen == "false" || citizen == "f" || citizen == "n" || citizen == "no"){
                  isCitizen = false;
                  keepAsking = false;
              }  

                
                //isCitizen = bool.Parse(System.Console.ReadLine());
           }

            if (age >= 18 && isCitizen == true)
            { canVote = true; }
            else
            { canVote = false; };


            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("Full name: " + fullName);
            System.Console.WriteLine("Total Height in Centimeters: " + totalHeightCM);
            System.Console.WriteLine("Can you vote?: " + canVote);

            System.Console.WriteLine("");
            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadKey();
        }
    }
}
