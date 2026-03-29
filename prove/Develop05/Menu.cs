using System;

public class Menu
{
    private Goals _goals;

    public Menu(Goals goals)
    {
        _goals = goals;
    }

    public void DisplayMenu()
    {
        string choice = "";

        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine("You have " + _goals.GetScore() + " points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                _goals.DisplayGoals();
                Console.WriteLine();
                Console.Write("Press Enter to continue. ");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                Console.WriteLine();
                _goals.DisplayGoals();
                Console.Write("Which goal did you accomplish? ");
                int number = int.Parse(Console.ReadLine());
                _goals.RecordEvent(number - 1);
                Console.WriteLine();
                Console.Write("Press Enter to continue. ");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();
                _goals.SaveGoals(fileName);
                Console.WriteLine("Goals saved.");
                Console.Write("Press Enter to continue. ");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                Console.Write("Enter filename: ");
                string fileName = Console.ReadLine();
                _goals.LoadGoals(fileName);
                Console.WriteLine("Goals loaded.");
                Console.Write("Press Enter to continue. ");
                Console.ReadLine();
            }
            else if (choice == "6")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                Console.Write("Press Enter to continue. ");
                Console.ReadLine();
            }
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            _goals.AddGoal(new SimpleGoal(name, description, points));
        }
        else if (type == "2")
        {
            _goals.AddGoal(new EternalGoal(name, description, points));
        }
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished? ");
            int targetAmount = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for completing it? ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.AddGoal(new ChecklistGoal(name, description, points, targetAmount, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
        }

        Console.WriteLine("Goal created.");
        Console.Write("Press Enter to continue. ");
        Console.ReadLine();
    }
}