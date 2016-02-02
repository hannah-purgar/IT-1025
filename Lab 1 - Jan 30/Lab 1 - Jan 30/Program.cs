namespace Lab_1___Jan_30
{
    class Program
    {
        static void Main(string[] args)
        {

            // GATHERING USER NAME
            System.Console.Write("What is your first name? ");
            string firstName;
                firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            string middleInitial;
                middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            string lastName;
                lastName = System.Console.ReadLine();


            // COMPILING FULL NAME
            string fullName = firstName + " " + middleInitial + ". " + lastName;


            // GATHERING USER HEIGHT
            System.Console.Write("What is your height in feet? 4, 5, or 6? ");
            int heightFeet;
                heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches are you beyond this base height? ");
            double heightInches;
                    heightInches = double.Parse(System.Console.ReadLine());


            // CONVERT INCHES TO CENTIMETERS
            double totalHeightCM = 0;
            double heightFeetToCM = ((heightFeet * 12) * 2.54);
            double heightInchesToCM = (heightInches * 2.54);
            totalHeightCM = heightFeetToCM + heightInchesToCM;


            // VOTER ELIGIBILITY
            System.Console.Write("How old are you? ");
            int age;
                age = int.Parse(System.Console.ReadLine());

            System.Console.Write("Are you a citizen? (true/false) ");
            bool isCitizen;
                isCitizen = bool.Parse(System.Console.ReadLine());

            bool isOfAge = age >= 18;

            bool canVote = isCitizen && isOfAge;

            System.Console.Write("Your Full Name is: " + fullName + ". ");
            System.Console.Write("Your Total Height is: " + totalHeightCM + "cm. ");
            System.Console.Write("Are You Able to Vote? " + canVote + ". ");
            System.Console.ReadKey();
           




        }
    }
}
