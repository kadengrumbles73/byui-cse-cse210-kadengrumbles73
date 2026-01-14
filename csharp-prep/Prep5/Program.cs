using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNum = PromptUserNumber();
        int squareNum = SquareNumber(userNum);

        int birthYear;
        PromptUserBirthYear(out birthYear);
        DisplayResult(userName, squareNum, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please Enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write($"Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());

    }
    static int SquareNumber(int number)
    { 
        int square = number * number;
        return square;
    }

    static void DisplayResult(string userName, int squareNum, int birthYear)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNum}.");
        Console.WriteLine($"{userName}, you will turn {2026 - birthYear} years old this year.");
    }
}