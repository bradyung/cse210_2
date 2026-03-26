using System;

class Program
{
    static void Main(string[] args)
    {
        // Goal myGoal = new Goal();
        // myGoal.SetName();
        // myGoal.SetDescription();
        // myGoal.SetPoints();
        // Console.WriteLine(myGoal.GetConsoleString());
        SimpleGoal mySimpleGoal = new SimpleGoal();
        mySimpleGoal.CreateGoal();
        Console.WriteLine(mySimpleGoal.GetConsoleString());
    }
}