using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        int percent;
    

        Console.Write("Please input your grade percentage: ");
        percent = int.Parse(Console.ReadLine());

        string letter;

        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent >= 80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }

        else if (percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your final letter grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");

        }
        else
        {
            Console.WriteLine("You didn't pass the couse. Better luck next time!");
        }

    
    }
}