using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool done = false;
        int userResponse;
        do
        {
            userResponse = menu.ProcessMenu();
            switch (userResponse)
            {
                case 1:
                    // Create a new journal entry here
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.WriteLine("Your response:");
                    string response = Console.ReadLine();

                    int wordCount = 0;

                    string[] words = response.Split(' ');
                    wordCount = words.Length;

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;
                    newEntry._wordCount = wordCount;

                    journal.AddEntry(newEntry);

                    Console.WriteLine($"Journal entry added. Word count: {wordCount}");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();


                    
                    // add entry to list of journal entries
                    break;
                case 2:
                    // Display journal entries here

                    Console.WriteLine();
                    journal.DisplayAll();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();

                    break;
                case 3:
                    // save journal to file
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);

                    Console.WriteLine($"Journal saved to {saveFile}.");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();

                    break;
                case 4:
                    // load journal from file
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    journal.DisplayAll();
                    
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();

                    
                    break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);
    }
}
        