

namespace HannahPurgarSpring2016Final
{
    class Elevator
    {
        private double MaxWeight = 0;
        private double currentWeight = 0;
        private int currentIndex = 0;
        Passenger[] Occupants;
      
        // ELEVATORS -> Max # of Occupants, Max Weight
        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        // ELEVATORS HAVE OCCUPANTS -> Array
        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
            currentIndex = index;
            this.addWeight();
        }

        // TOTAL WEIGHT OF OCCUPANTS
        public double GetCurrentWeight()
        {
            //System.Console.WriteLine("1Total Weight of Elevator Occupants: " + this.currentWeight);
            //this.currentWeight = this.currentWeight + Occupants[this.currentIndex].GetWeight();
           // System.Console.WriteLine("2Total Weight of Elevator Occupants: " + this.currentWeight);
           
            return currentWeight;
        }

        public void addWeight()
        {
            this.currentWeight = this.currentWeight + this.Occupants[this.currentIndex].GetWeight();
           // System.Console.WriteLine("3Total Weight of Elevator Occupants: " + this.currentWeight);
            // return currentWeight;
        }

        // IS ELEVATOR OVER CAPACITY?
        public bool IsOverMaxCapacity()
        {
            //System.Console.WriteLine("Current Weight is: " + this.GetCurrentWeight() + " |Max Weight: " + this.MaxWeight);
            return this.GetCurrentWeight() > this.MaxWeight ;
                     
        }
    }
}
