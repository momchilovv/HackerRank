using System;
using System.Collections.Generic;

namespace Day8.DictionariesAndMaps
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneBook = new Dictionary<string, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                phoneBook.Add(input[0], int.Parse(input[1]));
            }
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (!phoneBook.ContainsKey(input))
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine($"{input}=" +
                        $"{phoneBook[input]}");
                }
            }
        }
    }
}