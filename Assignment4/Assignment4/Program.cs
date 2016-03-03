using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            double ticketChild;
            double ticketAdult;
            double ticketSenior;

            double smallSoda = 3.50;
            double largeSoda = 5.99;
            double hotDog = 3.99;
            double popCorn = 4.50;
            double candy = 1.99;

            ShowMainMenu();
            ShowInputPrompt();
            string option = System.Console.ReadLine();
            if (option == "1") {
                ticketChild = 3.99;
                ticketAdult = 5.99;
                ticketSenior = 4.50;                
            }
            else {
                ticketChild = 6.99;
                ticketAdult = 10.99;
                ticketSenior = 8.50;
            }
            Console.WriteLine();
            System.Console.Write("     * How many Children?    ");
            int numChild = int.Parse((System.Console.ReadLine()));
            System.Console.Write("     * How many Adults?      ");
            int numAdult = int.Parse(System.Console.ReadLine());
            System.Console.Write("     * How many Seniors?     ");
            int numSenior = int.Parse(System.Console.ReadLine());

            System.Console.Write("     * How many Small Soda?  ");
            int numSmallSoda = int.Parse(System.Console.ReadLine());
            System.Console.Write("     * How many Large Soda?  ");
            int numLargeSoda = int.Parse(System.Console.ReadLine());
            System.Console.Write("     * How many Hot Dogs?    ");
            int numHotDog = int.Parse(System.Console.ReadLine());
            System.Console.Write("     * How many Pop Corns?   ");
            int numPopCorn = int.Parse(System.Console.ReadLine());
            System.Console.Write("     * How many Candies?     ");
            int numCandy = int.Parse(System.Console.ReadLine());
            Console.WriteLine();

            double totalPrice = 0;
            double totalTicket = 0;
            totalTicket = totalTicket + (numChild * ticketChild);
            totalTicket = totalTicket + (numAdult * ticketAdult);
            totalTicket = totalTicket + (numSenior * ticketSenior);

            totalPrice = totalPrice + (numSmallSoda * smallSoda);
            totalPrice = totalPrice + (numLargeSoda * largeSoda);
            totalPrice = totalPrice + (numHotDog * hotDog);
            totalPrice = totalPrice + (numPopCorn * popCorn);
            totalPrice = totalPrice + (numCandy * candy);           

            int ticketDiscount = 0;
            if (numPopCorn >= 1 && numLargeSoda >= 1 )
            {
                if(numPopCorn <= numLargeSoda)
                {
                    ticketDiscount = numPopCorn * 2;
                }
                else
                {
                    ticketDiscount = numLargeSoda * 2;
                }
                Console.WriteLine("     >>> You got " + ticketDiscount + " dollar discount in your tickets <<<");
            }
            totalTicket = totalTicket - ticketDiscount;
            totalPrice = totalPrice + totalTicket;

            int totalPeople = numChild + numAdult + numSenior;
            if (option == "2" && totalPeople >= 3)
            {
                Console.WriteLine("     >>> You got 1 free bag of popcorn <<<");
            }

            if (numCandy >= 3)
            {
                int freeCandy = (int)(numCandy / 3);
                if (freeCandy == 1)
                {
                    Console.WriteLine("     >>> You got " + freeCandy + " free candy <<<");
                }
                else {
                    Console.WriteLine("     >>> You got " + freeCandy + " free candies <<<");
                }         
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("     Total Tickets Price = " + totalTicket);
            Console.WriteLine("     Gran Total          = " + totalPrice);
            Console.ReadKey();
        }


        private static void ShowMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine(" ======================================================= ");
            Console.WriteLine("        What time do you want to watch the movie ?       ");
            Console.WriteLine(" ======================================================= ");
            Console.WriteLine();
            Console.WriteLine("                  (1) - Matinee                          ");
            Console.WriteLine("                  (2) - Evening                          ");
            Console.WriteLine();
            Console.WriteLine(" ======================================================= ");
        }


        private static void ShowInputPrompt()
        {
            Console.WriteLine();
            Console.Write("              ---> ");
        }
        
    }
}
