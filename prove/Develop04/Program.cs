/* The code snippet you provided is a C# program that presents a menu to the user with different
options. The program will continue to display the menu and prompt the user to select a choice until
the user enters "4" to quit. */
using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }

            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.Run();
            }

            else if (choice == "3")
                {
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                }

            else
            {
                Console.WriteLine("See you later!");
            }
        }
    }
}