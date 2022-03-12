using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            Console.WriteLine("Type the max number for the guessing game");
            int maxNumber = int.Parse(Console.ReadLine());
            int theNumber = new Random().Next(maxNumber);
            bool right = false;
            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine($"I'm thinking of a number between 0 and {maxNumber}.");
            
            int guess;
            int times = 1;
            do 
            {
                Console.WriteLine("Enter your guess, or -1 to give up.");
                
                guess = int.Parse(Console.ReadLine());
                if (guess == -1)
                {
                    Console.WriteLine("You gave up");
                    break;
                }
                if (guess == theNumber)
                {
                    right = true;
                    break;
                }
                else if (guess < theNumber)
                {
                    Console.WriteLine("Wrong Number!!!");
                    Console.WriteLine("Guess higher");

                }
                else
                {
                    Console.WriteLine("Wrong Number!!!");
                    Console.WriteLine("Guess lower");
                }
                times++;
                
            }   while (times < maxNumber/2);
            
            Console.WriteLine(right ? "Your guessed right" : "Game Over");
            Console.WriteLine($"It took you {times} tries");



            
        }
    }
}
