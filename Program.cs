using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random generating a number
            Random random = new Random();
            int guessingNumber = random.Next(1, 20);
            
            int guesses = 0;
            int userChoice;

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");
            
            // user amount of guesses
            while (guesses <= 4) 
            {
                
                int.TryParse(Console.ReadLine(), out userChoice);
                CheckGuess(userChoice, guessingNumber);
                guesses++;
            }
            Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");

        }
        // Method to check right or wrong guesses
        public static void CheckGuess(int userChoice, int guessingNumber) 
        {
            if (userChoice > guessingNumber)
            {
                Console.WriteLine("Tyvärr du gissade för högt!");
            }
            else if (userChoice < guessingNumber)
            {
                Console.WriteLine("Tyvärr du gissade för lågt!");
            }
            else
            {
                Console.WriteLine("Woho! Du gjorde det!");
                Environment.Exit(0);
            }
        }
           
    }
}
