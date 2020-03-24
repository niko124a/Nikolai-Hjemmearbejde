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
            int tries = 0;

            while (true)
            {
                Console.WriteLine("Hello player, welcome to this EPIC game, where you are supposed to guess a number between 0 and 10");
                Console.WriteLine("To get started, press 1");


                for (tries = 3; tries > 0; tries--)
                {
                    var playerInput = Console.ReadKey();
                    if (playerInput.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Console.WriteLine($"Please type your guess here: ");
                        playerGuess = Console.ReadLine();

                        if (Convert.ToInt32(playerGuess) == number)
                        {
                            Console.WriteLine("You won!");
                            tries = 3;
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (Convert.ToInt32(playerGuess) < number)
                        {
                            Console.WriteLine("Your guess was too low");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (Convert.ToInt32(playerGuess) > number)
                        {
                            Console.WriteLine("Your guess was too high");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (tries == 0)
                        {
                            Console.WriteLine("Game over!");
                            Console.ReadKey();
                            Console.Clear();
                        }

                        tries--;
                        Console.WriteLine($"You now have {tries} left");
                    }
                }
            }
        }
    }
}
