namespace _31_Challenge_FountainOfObjects;

public static class ConsoleHelper
{
    public static void PrintColour(this string message, ConsoleColor colour)
    {
        Console.ForegroundColor = colour;
        Console.WriteLine(message);
        Console.ResetColor();
    }
}
