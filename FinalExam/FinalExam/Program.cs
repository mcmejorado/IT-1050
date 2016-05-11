using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Step 3 – In Your Main Program:
 Declare a local variable named elevator1 which is an Elevator.
 Instantiate elevator1, with a maxOccupants of 2, and a maxWeight of 400.
 AddOccupant to elevator1, with a name of “A1”, weight of 180, and index of 0.
 AddOccupant to elevator1, with a name of “A2”, weight of 220, and index of 1.
 Declare a local variable named elevator1IsOverMaxCapacity which is a bool.
 Assign elevator1IsOverMaxCapacity the value of IsOverMaxCapacity for elevator1.
 Debug your program to make sure the value of elevator1IsOverMaxCapacity is false.
 Declare a local variable named elevator2 which is an Elevator.
 Instantiate elevator2, with a maxOccupants of 3, and a maxWeight of 600.
 AddOccupant to elevator2, with a name of “A1”, weight of 200, and index of 0.
 AddOccupant to elevator2, with a name of “A2”, weight of 200, and index of 1.
 AddOccupant to elevator2, with a name of “A3”, weight of 201, and index of 2.
 Declare a local variable named elevator2IsOverMaxCapacity which is a bool.
 Assign elevator2IsOverMaxCapacity the value of IsOverMaxCapacity for elevator2.
 Debug your program to make sure the value of elevator2IsOverMaxCapacity is true
*/
namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator1 = new Elevator(2, 400);
            Passenger passenger = new Passenger("A1", 180);
            elevator1.AddOccupant(passenger, 0);
            Passenger passenger1 = new Passenger("A2", 220);
            elevator1.AddOccupant(passenger1, 1);
            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity(); //must be false
            System.Console.WriteLine("Elevator1 is over max capacity? " + elevator1IsOverMaxCapacity);

            Elevator elevator2 = new Elevator(3,600);
            Passenger passenger2 = new Passenger("A1", 200);
            elevator2.AddOccupant(passenger2, 0);
            Passenger passenger3 = new Passenger("A2", 200);
            elevator2.AddOccupant(passenger3, 1);
            Passenger passenger4 = new Passenger("A3", 201);
            elevator2.AddOccupant(passenger4, 2);
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity(); //must be true
            System.Console.WriteLine("Elevator2 is over max capacity? " + elevator2IsOverMaxCapacity);
            System.Console.ReadKey();
        }
    }
}
