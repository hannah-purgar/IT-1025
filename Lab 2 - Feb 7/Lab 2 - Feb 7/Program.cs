
namespace Lab_2___Feb_7
{
    class Program
    {
        static void Main(string[] args)
        {

               // Setting initial Sum of Ages to 0 //
            Person.SumOfAllAges = 0;

               // Person1 becomes a new Person //
            Person Person1 = Person.CreatePerson("");
            // Person1 has a spouse that is created using the code in CreatePerson (Person Class) //
            Person1.Spouse = Person.CreatePerson("Spouse ");



               // Person2 becomes a new Person //
            Person Person2 = Person.CreatePerson("");
               // Person2 has a spouse that is created using the code in CreatePerson (Person Class)//
            Person2.Spouse = Person.CreatePerson("Spouse ");

               // Displaying & Calculating the average age of all Persons //
            System.Console.WriteLine("Average Age         : " + Person.SumOfAllAges / 4);
            System.Console.ReadKey();
            
            


        }
    }
}
