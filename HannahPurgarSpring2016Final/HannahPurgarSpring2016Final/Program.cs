

namespace HannahPurgarSpring2016Final
{
    class Program
    {
        static void Main(string[] args)
        {
            // ELEVATOR #1
            Elevator elevator1 = new Elevator(2, 400);
            Passenger A1 = new Passenger("A1", 180);
            elevator1.AddOccupant(A1, 0);
            //System.Console.WriteLine("1Elevator 1 weight: " + elevator1.GetCurrentWeight());

            Passenger A2 = new Passenger("A2", 220);
            elevator1.AddOccupant(A2, 1);
            //System.Console.WriteLine("2Elevator 1 weight: " + elevator1.GetCurrentWeight());

            bool elevator1IsOverMaxCapacity = elevator1.IsOverMaxCapacity();
            //System.Console.WriteLine("Elevator 1 is Overweight: " + elevator1IsOverMaxCapacity);
            //System.Console.WriteLine("Elevator 1 weight: " + elevator1.GetCurrentWeight());


            // ELEVATOR #2
            Elevator elevator2 = new Elevator(3, 600);
            Passenger A3 = new Passenger("A1", 200);
            elevator2.AddOccupant(A3, 0);
            //System.Console.WriteLine("1Elevator 2 weight: " + elevator2.GetCurrentWeight());
            Passenger A4 = new Passenger("A2", 200);
            elevator2.AddOccupant(A4, 1);
            //System.Console.WriteLine("2Elevator 2 weight: " + elevator2.GetCurrentWeight());
            Passenger A5 = new Passenger("A3", 201);
            elevator2.AddOccupant(A5, 2);
            //System.Console.WriteLine("3Elevator 2 weight: " + elevator2.GetCurrentWeight());
            bool elevator2IsOverMaxCapacity = elevator2.IsOverMaxCapacity();

            System.Console.WriteLine("Elevator 1 is Overweight: " + elevator1IsOverMaxCapacity);
            System.Console.WriteLine("Elevator 2 is Overweight: " + elevator2IsOverMaxCapacity);
            System.Console.WriteLine("Elevator 1 weight: " + elevator1.GetCurrentWeight());
            System.Console.WriteLine("Elevator 2 weight: " + elevator2.GetCurrentWeight());

            System.Console.Read();




        }
    }
}
