using System;

class Program
{
    static void Main(string[] args)
    {
        Goal myGoal = new Goal();
        myGoal.SetName();
        Console.WriteLine(myGoal.GetConsoleString());
    }
}