using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        DateTime parsed = DateTime.Parse(input);

        Console.WriteLine(parsed.ToString("HH:mm:ss"));
    }
}