/* For the creativity portion of this assignment 
I created a database using sqlite to save the 
responses of the journal. I did change the menu options
to make more sense. Option 3 is now "load from database"
and Option 4 is "Sync Status"
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal.LoadFromDatabase();
        PromptGenerator promptGenerator = new PromptGenerator();
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nWelcome to the Journal App!");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load from Database");
            Console.WriteLine("4. Sync Status");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();
        
            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"\n{prompt}");
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                myJournal.LoadFromDatabase();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Entries are automatically saved to journal.db.");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
        } 
    }
}