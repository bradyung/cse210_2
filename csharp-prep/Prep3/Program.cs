using System;

class Program
{
    static void Main(string[] args)
    {

        
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        int guess;

        Console.Write("Guess the magic number? ");
        guess = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);

        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You guessed it!");

    }
}