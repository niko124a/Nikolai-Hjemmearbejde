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

            while (true)
            {
                Console.WriteLine("Hello player, welcome to this EPIC game, where you are supposed to guess a number between 0 and 10");
                Console.WriteLine("To get started, press 1");
                var playerInput = Console.ReadKey();
                if (playerInput.Key == ConsoleKey.D1)
                {




                    tries--;
                    Console.WriteLine($"You now have {tries} left");
                }
            }
        }
    }
}
