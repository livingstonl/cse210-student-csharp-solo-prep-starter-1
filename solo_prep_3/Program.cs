using System;

namespace solo_prep_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 11);
            int guess = 0;
            
            do
            {
                Console.Write("Guess my number between 1 - 11: ");
                string input = Console.ReadLine();
                guess = int.Parse(input);

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }    
                else if (guess < number)
                {
                Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } 
            while (guess != number);
            
        }
    }
}
