
namespace Lab_2___Feb_7
{
    class Person
    {

            //          Establishing Variables         //

        public int age;
        public string FirstName;
        public string LastName;
        public Person Spouse;
        public static double SumOfAllAges;
        string PrintNameAndAge;


             //             Creating People              //

               // When asking for Spouse's information "Spouse" will be displayed in front //
        public static Person CreatePerson(string prefix)
        {

               // New Person is Created (all info below is stored inside them) //
            Person Person = new Person();

               // Get First Name //
            System.Console.Write(prefix + "First Name          : ");
            Person.FirstName = System.Console.ReadLine();

               // Get Last Name //
            System.Console.Write(prefix + "Last Name           : ");
            Person.LastName = System.Console.ReadLine();

               // Get Age //
            System.Console.Write(prefix + "Age                 : ");
            Person.age = int.Parse(System.Console.ReadLine());

               // Add Age (above) to Total SumOfAges //
            Person.SumOfAllAges += Person.age;

               // Return to top to create new Person //
            return Person;
        }



    }
}
