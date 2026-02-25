using System;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        int age;

        Console.Write("Please input your age: ");
        // string response = Console.ReadLine();
        // age = int.Parse(response);

        age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Your age is: {age}");

        int x = 20;
        double z =  12.21;
        if (age <= 100 && x <= 30 || z < 6)

        if (age <= 100)
        {
            Console.WriteLine("You are cool");
        }
        else if (age <= 150)
        {
            Console.WriteLine("You are sort of cool");
        }

        else
        {
            Console.WriteLine("wow you have had a lot of birthdays");
        }

    }
}