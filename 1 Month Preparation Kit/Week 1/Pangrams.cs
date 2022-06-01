using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int index = 0;
        int[] letter = new int[26];

        for (int i = 0; i < input.Length; i++)
        {
            if ('A' <= input[i] && input[i] <= 'Z')
                index = input[i] - 'A';

            else if ('a' <= input[i] && input[i] <= 'z')
                index = input[i] - 'a';

            letter[index]++;
        }

        for (int i = 0; i < 25; i++)
        {
            if (letter[i] < 1)
            {
                Console.WriteLine("not pangram");
                Environment.Exit(0);
            }
        }
        Console.WriteLine("pangram");
    }
}