using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep 1 World!");
        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();
        Console.WriteLine($"{last_name}, {first_name} {last_name}");
    }
}
