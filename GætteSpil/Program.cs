using System;

namespace GætteSpil
{
    class Program
    {
        public static string playerGuess = Console.ReadLine();

        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int number = randomNum.Next(11);
            int tries = 3;


           


            while (tries >= 0)
            {
                Console.WriteLine("Hello player, welcome to this EPIC game, where you are supposed to guess a number between 0 and 10");
                Console.WriteLine("To get started, press any key");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine($"Please type your guess here: ");
                playerGuess = Console.ReadLine();

                if (Convert.ToInt32(playerGuess) == number)
                {
                    Console.WriteLine("You won!");
                    tries = 3;
                    number = randomNum.Next(11);
                    Console.ReadKey();
                    Console.Clear();

                }
                if (Convert.ToInt32(playerGuess) < number)
                {
                    Console.WriteLine("Your guess was too low");
                    Console.ReadKey();
                    Console.Clear();
                    tries--;
                }
                if (Convert.ToInt32(playerGuess) > number)
                {
                    Console.WriteLine("Your guess was too high");
                    Console.ReadKey();
                    Console.Clear();
                    tries--;
                }
                if (tries == 0)
                {
                    Console.WriteLine("Game over!");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to try again");
                    Console.ReadKey();
                    Console.Clear();
                    tries = 3;
                    number = randomNum.Next(11);

                }

                Console.WriteLine($"You now have {tries} tries left");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
