
namespace Lab_2___Feb_7
{
    class Program
    {
        static void Main(string[] args)
        {

               // Setting initial Sum of Ages to 0 //
            Person.SumOfAllAges = 0;

               // Person1 becomes a new Person //
            Person P1 = Person.CreatePerson("");
            // P1 has a spouse that is created using the code in CreatePerson (Person Class) //
            P1.Spouse = Person.CreatePerson("Spouse ");



               // Person2 becomes a new Person //
            Person P2 = Person.CreatePerson("");
               // P2 has a spouse that is created using the code in CreatePerson (Person Class)//
            P2.Spouse = Person.CreatePerson("Spouse ");

               // Displaying & Calculating the average age of all Persons //
            System.Console.WriteLine("Average Age         : " + Person.SumOfAllAges / 4);
            System.Console.ReadKey();

            // Displaying each person's name //
            System.Console.WriteLine(P1.LastName + ", " + P1.FirstName + " (" + P1.age + ")");
            System.Console.ReadKey();
            System.Console.WriteLine(P1.Spouse.LastName + ", " + P1.Spouse.FirstName + " (" + P1.Spouse.age + ")");
            System.Console.ReadKey();
            System.Console.WriteLine(P2.LastName + ", " + P2.FirstName + " (" + P2.age + ")");
            System.Console.ReadKey();
            System.Console.WriteLine(P2.Spouse.LastName + ", " + P2.Spouse.FirstName + " (" + P2.Spouse.age + ")");
            System.Console.ReadKey();


        }
    }
}
