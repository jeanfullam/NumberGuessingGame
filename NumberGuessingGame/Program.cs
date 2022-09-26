/*
Purpose: User to guess a randomly generated number between  and  inclusive
Inout: a guess
Output: right or wrong
date: 26/09/2022
*/
using System.Diagnostics.Metrics;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
           Random random = new Random();
            int computerNumber = random.Next(1,101);
            int guess,
                counter = 0;

            //user inputs a guess
            Console.WriteLine("Enter a guess between 1 and 100 inclusive");
            guess = int.Parse(Console.ReadLine());

            //loop
            // - guess > random number --> "too high"
            // - guess < random number --> "too low"
            while(guess != computerNumber)
            {
                counter++;
                if (guess > computerNumber)
                {
                    Console.WriteLine($"Your guess {guess} is too high");
                }
                else
                {
                    Console.WriteLine($"Your guess {guess} is too low");
                }
                Console.WriteLine("Enter a guess between 1 and 100 inclusive");
                guess = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"You chose wisely but you made {counter} bad guesses");
            Console.ReadLine();
        }
    }
}