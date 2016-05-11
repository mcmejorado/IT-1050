using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Step 2 – Create a class called “Elevator”:
 Two private member variables:
o MaxWeight, which is a double.
o Occupants, which is an array of Passengers.
 One public constructor:
o Takes two parameters: maxOccupants, which is an int, and maxWeight, which is a double.
o Creates new memory for the Occupants array to be the size of maxOccupants.
o Assigns MaxWeight the value of maxWeight.
 Three public methods:
o AddOccupant
 Takes two parameters: passenger, which is a Passenger, and index, which is an int.
 Assigns Occupants at position index the value of passenger.
 No return value. (void)
o GetCurrentWeight, which returns the sum of the weights of all occupants in this Elevator.
o IsOverMaxCapacity, which returns whether or not GetCurrentWeight is greater than MaxWeight.
    */


namespace FinalExam
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            return MaxWeight += MaxWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return GetCurrentWeight() > MaxWeight;
        }           
    }
}
