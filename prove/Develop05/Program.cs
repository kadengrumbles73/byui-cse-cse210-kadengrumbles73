using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> _goals = new List<Goal>();
    static int _score = 0;

    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine($"\nScore: {_score} | Level: {GetLevel()}");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoals();
            else if (choice == "3") Save();
            else if (choice == "4") Load();
            else if (choice == "5") Record();
        }
    }

    static int GetLevel()
    {
        if (_score == 0) return 1;
        return (int)(Math.Sqrt(_score) / 5) + 1;
    }

    static void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1") _goals.Add(new SimpleGoal(name, desc, points));
        else if (type == "2") _goals.Add(new EternalGoal(name, desc, points));
        else if (type == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    static void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    static void Record()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count) return;

        Goal goal = _goals[index];
        int oldLevel = GetLevel();
        
        goal.RecordEvent();
        int earned = goal.GetPoints();

        if (goal is ChecklistGoal cl && cl.IsComplete())
        {
            earned += cl.GetBonus();
        }

        _score += earned;
        Console.WriteLine($"Congratulations! You earned {earned} points!");

        if (GetLevel() > oldLevel)
        { 
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"LEVEL UP! You reached Level {GetLevel()}!");
            Console.ResetColor();
        }
    }

    static void Save()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();
        using (StreamWriter sw = new StreamWriter(file))
        {
            sw.WriteLine(_score);
            foreach (Goal g in _goals) sw.WriteLine(g.GetStringRepresentation());
        }
    }

    static void Load()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();
        if (!File.Exists(file)) return;
        
        string[] lines = File.ReadAllLines(file);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string type = parts[0];
            string[] data = parts[1].Split(",");

            if (type == "SimpleGoal") 
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
            else if (type == "EternalGoal") 
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
            else if (type == "ChecklistGoal") 
                _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5])));
        }
    }
}