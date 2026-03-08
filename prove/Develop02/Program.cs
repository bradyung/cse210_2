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

                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;

                    journal.AddEntry(newEntry);

                    Console.WriteLine("Journal entry added.");
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
                    Console.WriteLine("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    journal.SaveToFile(saveFile);
                    break;
                case 4:
                    // load journal from file
                    Console.WriteLine("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded.");
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
        