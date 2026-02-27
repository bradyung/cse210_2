using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> myData = new List<int>();
        Console.WriteLine("Enter numbers to add to the list, type 0 when finished. ");
        Console.Write("Enter number: ");
        int input = int.Parse(Console.ReadLine());
        do
        {
            Console.Write("Enter number: ");
            myData.Add(input);
            input = int.Parse(Console.ReadLine());
        }while (input != 0);
        Console.WriteLine("The sum is: " + myData.Sum());
        Console.WriteLine("The average is: " + myData.Average());
        Console.WriteLine("The largest number is: " + myData.Max());
    }
}