
using System;

namespace Lab_4___April_12
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////
            double totalCost = 0;

            // CHILD //
            double childMatinee = 3.99;
            double childEvening = 6.99;
            // ADULT //
            double adultMatinee = 5.99;
            double adultEvening = 10.99;
            // SENIOR //
            double seniorMatinee = 4.50;
            double seniorEvening = 8.50;
            // CONCESSIONS //
            double smallSoda = 3.50;
            double largeSoda = 5.99;
            double hotdog = 3.99;
            double popcorn = 4.50;
            double candy = 1.99;

            //////////////////////////////////////////////////////////////////////////////////////
            // TICKET TYPE //
            System.Console.WriteLine("Hello, and welcome to Hannah's Theatre! ");
            System.Console.WriteLine();
            System.Console.WriteLine("Please answer the following. Enter 1 (yes) or 0 (no). ");
            System.Console.Write("Will you be attending a Matinee showing? ");
            int showing = int.Parse(Console.ReadLine());
            if (showing > 1 || showing < 0)
            {
                System.Console.WriteLine("Error. Please enter 1 (yes) or 0 (no).");
                System.Console.WriteLine("Please close the program, and try again.");
                System.Console.ReadLine();
            }
            System.Console.WriteLine();

            // QUANTITY TIX//
            System.Console.WriteLine("Thank you. Please enter the number of tickets needed for each age group. ");
            System.Console.WriteLine();
            System.Console.WriteLine("# of Child Tickets: ");
            int childTix = int.Parse(Console.ReadLine());
            System.Console.WriteLine("# of Adult Tickets: ");
            int adultTix = int.Parse(Console.ReadLine());
            System.Console.WriteLine("# of Senior Tickets: ");
            int seniorTix = int.Parse(Console.ReadLine());
            System.Console.WriteLine();
            int totalTix = childTix + adultTix + seniorTix;

            // QUANTITY FOOD //
            System.Console.WriteLine("Excellent. If you would like to purchase concession, please enter each quantity. ");
            System.Console.WriteLine();
            System.Console.WriteLine("# of Small Sodas: ");
            int numSmall = int.Parse(Console.ReadLine());
            System.Console.WriteLine("# of Large Sodas: ");
            int numLarge = int.Parse(Console.ReadLine());
            System.Console.WriteLine("# of Hot Dogs: ");
            int numHot = int.Parse(Console.ReadLine());
            System.Console.WriteLine("# of Popcorn: ");
            int numPop = int.Parse(Console.ReadLine());
            System.Console.WriteLine("# of Candy: ");
            int numCandy = int.Parse(Console.ReadLine());

            //////////////////////////////////////////////////////////////////////////////////////
            // GENERAL TOTALING //
            if (showing == 1)
            {
                totalCost = totalCost + (childTix * childMatinee) + (adultTix * adultMatinee) + (seniorTix * seniorMatinee);
                totalCost = totalCost + (numSmall * smallSoda) + (numLarge * largeSoda) + (numHot * hotdog) + (numPop * popcorn) + (numCandy * candy);
            }
            else if (showing > 1 || showing <0)
            {
                System.Console.WriteLine("Error. Please enter 1 (yes) or 0 (no). ");
            }
            else
            {
                totalCost = totalCost + (childTix * childEvening) + (adultTix * adultEvening) + (seniorTix * seniorEvening);
                totalCost = totalCost + (numSmall * smallSoda) + (numLarge * largeSoda) + (numHot * hotdog) + (numPop * popcorn) + (numCandy * candy);
            }

            //////////////////////////////////////////////////////////////////////////////////////
            // DISCOUNTS //

                // POPCORN & LARGE SODA //
            int popCounter = numPop;
            int largeCounter = numLarge;
            int tixCounter = totalTix;

            while (popCounter >= 1 && largeCounter >= 1 && tixCounter >=1)
            {
                totalCost = totalCost - 2;
                popCounter = popCounter - 1;
                largeCounter = largeCounter - 1;
                tixCounter = tixCounter - 1;
            }

                // CANDY //
            int candyCounter = numCandy;

            while (candyCounter >= 4)
            {
                totalCost = totalCost - candy;
                candyCounter = candyCounter - 4;
            }

            // POPCORN & TICKETS //
            int ticketCounter = totalTix;
            int popcornCounter = numPop;

            if (showing == 0)
            {
                while (ticketCounter >= 3 && popcornCounter >= 1)
                {
                    totalCost = totalCost - popcorn;
                    ticketCounter = ticketCounter - 3;
                    popcornCounter = popcornCounter - 1;
                }
                    
            }
            
            System.Console.WriteLine("Your total is: $" + totalCost + "! Please enjoy the movie.");
            System.Console.ReadLine();
            




            




        }
    }
}
