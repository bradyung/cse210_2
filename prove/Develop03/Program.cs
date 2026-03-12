using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        string userInput = "";
        while(userInput.ToLower() != "q" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'q' to finish: ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() != "q")
            {
                scripture.HideRandomWords(3);
            }
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.WriteLine("Program ended.");
    }
}