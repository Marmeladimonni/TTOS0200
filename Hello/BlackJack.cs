using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace Hello
{
    class BlackJack
    {
        public static void Play()
        {
            int myNumber = 17;
            int theirNumber;
            Console.WriteLine("*** BlackJack! ***");
            Console.Write("Can you beat my number? Enter any number between 1-21: ");
            //reading and converting 
            theirNumber = Convert.ToInt32(Console.ReadLine());
            //comparing that given umber is valid
            while (theirNumber < 1 || theirNumber > 21)
            {
                Console.WriteLine("The given number is out of limits, try again.");

            }
            //comparing
            if (theirNumber >= myNumber && theirNumber <= 21)
            {
                Console.WriteLine("You win.");
                Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 
                theirNumber = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("You lose.");
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}