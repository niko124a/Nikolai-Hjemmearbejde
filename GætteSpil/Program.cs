using System;

namespace GætteSpil
{
    class Program
    {

        public static void Gættespil()
        {
            Random randomNum = new Random();
            int number = randomNum.Next(11);
            int tries = 3;




            Console.WriteLine("Hello player, welcome to this EPIC game, where you are supposed to guess a number between 0 and 10");
            Console.WriteLine("To get started, press any key");
            Console.ReadKey();
            while (tries >= 0)
            {
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
                    tries--;
                    Console.ReadKey();
                    Console.Clear();
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
                    tries = 3;
                    number = randomNum.Next(11);
                    Console.ReadKey();
                    Console.Clear();
                }

                Console.WriteLine($"You now have {tries} tries left");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static string playerGuess = Console.ReadLine();
        static void Main(string[] args)
        {
            while (true)
            {

                Random r = new Random();
                int val = r.Next(0, 10);
                int guess = 0;
                int Tries = 3;
                Console.Clear();
                Console.WriteLine("I'm thinking of a number between 0 and 10.");
                

                while (Tries != 0)
                {
                    Console.Write("Guess: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("That's not a number.");
                        continue;
                    }

                    if (guess < val)
                    {
                        Tries--;
                        Console.WriteLine($"No, the number is higher than {guess}.");
                    }
                    else if (guess > val)
                    {
                        Tries--;
                        Console.WriteLine($"No, the number I'm thinking is lower than {guess}.");
                    }
                    else
                    {
                        Tries = 3;
                        Console.WriteLine("You guessed right!");
                        Console.ReadKey();
                    }

                    if (Tries == 0)
                    {
                        Console.WriteLine("");
                    }
                }
            }
        }
    }
}
