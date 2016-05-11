

namespace HannahPurgarSpring2016Final
{
    class Passenger
    {
        private string Name;
        private double Weight = 0;
        public double totalWeightPassenger = 0;

        // PASSENGER -> Name, Weight
        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;

            //System.Console.WriteLine("iName: " + this.Name);
            //System.Console.WriteLine("iWeight: " + this.Weight);
        }



        // DISPLAY NAME
        public string GetName()
        {
            //System.Console.WriteLine("Name: " + this.Name);
            return this.Name;
        }

        // DISPLAY WEIGHT
        public double GetWeight()
        {
           //System.Console.WriteLine("Weight: " + this.Weight);
            return this.Weight;
        }
    }
}
