using System;
using System.Collections.Generic;
using System.IO;

public class Goals
{
    private List<Goal> _goals;
    private int _score;

    public Goals()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetScore()
    {
        return _score;
    }

    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + _goals[i].GetDisplayString());
            }
        }
    }

    public void RecordEvent(int goalNumber)
    {
        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            int pointsEarned = _goals[goalNumber].RecordEvent();
            _score = _score + pointsEarned;

            Console.WriteLine("You earned " + pointsEarned + " points!");
            Console.WriteLine("Your total score is now " + _score + ".");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetSaveString());
            }
        }
    }

    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName) == false)
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(fileName);

        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        _goals.Clear();
        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] data = line.Split("#");

            string goalType = data[0];

            if (goalType == "SimpleGoal")
            {
                string name = data[1];
                string description = data[2];
                int points = int.Parse(data[3]);
                bool isComplete = bool.Parse(data[4]);

                _goals.Add(new SimpleGoal(name, description, points, isComplete));
            }
            else if (goalType == "EternalGoal")
            {
                string name = data[1];
                string description = data[2];
                int points = int.Parse(data[3]);

                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = data[1];
                string description = data[2];
                int points = int.Parse(data[3]);
                int targetAmount = int.Parse(data[4]);
                int bonus = int.Parse(data[5]);
                int amountCompleted = int.Parse(data[6]);

                _goals.Add(new ChecklistGoal(name, description, points, targetAmount, bonus, amountCompleted));
            }
        }
    }
}