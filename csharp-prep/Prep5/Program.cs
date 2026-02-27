using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromtUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);
        int year;
        PromptUserBirthYear(out year);

        DisplayResults(name, squaredNumber, year);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromtUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birth year: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    


    static void DisplayResults(string name, int squaredNumber, int year)
    {
        // int currentYear = DateTime.Now.Year;
        // int ageThisYear = currentYear - year;

        Console.WriteLine($"{name}, the square of your favorite number is: {squaredNumber}");
        Console.WriteLine($"{name}, you will turn {2026 - year} years old this year.");
    }
}