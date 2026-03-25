using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Option:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflection activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity Reflection = new ReflectionActivity();
                Reflection.Run();
            }
            else if (choice == "3")
            {
                ListingActivity Listing = new ListingActivity();
                Listing.Run();
            }
            if (choice != "4")
            {
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }
        }
    }
}