
namespace Lab_2___Feb_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Creating two people. //
            Person p1 = new Person();
            Person p2 = new Person();

            //  Gathering information //

                // First Name //
            System.Console.Write("P1 First Name is: ");
            p1.FirstName = System.Console.ReadLine();

            System.Console.Write("P2 First Name is: ");
            p2.FirstName = System.Console.ReadLine();


            // Last Name //
            System.Console.Write("P1 Last Name is: ");
            p1.LastName = System.Console.ReadLine();

            System.Console.Write("P2 Last Name is: ");
            p2.LastName = System.Console.ReadLine();


            // Age //
            System.Console.Write("P1 Age is: ");
            p1.age = int.Parse(System.Console.ReadLine());

            System.Console.Write("P2 Age is: ");
            p2.age = int.Parse(System.Console.ReadLine());


            // Marital Status //
            System.Console.WriteLine("Is P1 married? ");
            p1.MarriageStatus = bool.Parse(System.Console.ReadLine());

            if (p1.MarriageStatus == true)
            {
                System.Console.Write("P1 Spouse Name is: ");
                p1.Spouse.FirstName = System.Console.ReadLine();
                p1.Spouse.LastName = p1.LastName;
            }
            else
            {

                sdfsd
            }



            System.Console.WriteLine("Is P2 married? ");
            p2.MarriageStatus = bool.Parse(System.Console.ReadLine());

            if (p2.MarriageStatus == true)
            {
                System.Console.Write("P2 Spouse Name is: ");
                p2.Spouse.FirstName = System.Console.ReadLine();
                p2.Spouse.LastName = p2.LastName;
            }
            else
            {

                sdfsd
            }



        }
    }
}
