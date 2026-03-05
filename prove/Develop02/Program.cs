using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool done = false;
        int userResponse;
        do
        {
            userResponse = menu.ProcessMenu();
            switch (userResponse)
            {
                case 1:
                    // Create a new journal entry here
                    // add entry to list of journal entries
                    break;
                case 2:
                    // Display journal entries here
                    break;
                case 3:
                    // save journal to file
                    break;
                case 4:
                    // load journal from file
                    break;
                case 5:
                    done = true;
                    break;
            }
        } while (!done);
    }
}
        