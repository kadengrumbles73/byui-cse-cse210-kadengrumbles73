using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Scripture> library = new List<Scripture>();

        library.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his only begotten Son"));
        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all thine heart and lean not unto thine own understanding"));
        library.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me"));

        Console.Clear();
        Console.WriteLine("Select a scripture to memorize:\n");
        for (int i = 0; i < library.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {library[i].GetReferenceOnly()}");
        }

        Console.Write("\nEnter the number of your choice: ");
        int selectionIndex = int.Parse(Console.ReadLine()) - 1;
        Scripture selectedScripture = library[selectionIndex];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());

            if (selectedScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            selectedScripture.HideRandomWords(3);
        }
    }
}