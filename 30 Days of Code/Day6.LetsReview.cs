using System;
using System.Collections.Generic;

class Solution
{
    static void Main(String[] args)
    {
        int testCases = int.Parse(Console.ReadLine());

        List<string> cases = new List<string>();
        List<char> evens = new List<char>();
        List<char> odds = new List<char>();

        for (int i = 0; i < testCases; i++)
        {
            string input = Console.ReadLine();
            cases.Add(input);
        }
        
        foreach (var item in cases)
        {
            for (int i = 0; i < item.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(item[i]);
                }
                else
                {
                    odds.Add(item[i]);
                }
            }
            Console.WriteLine($"{string.Join("", evens)} {string.Join("", odds)}");
            evens.Clear();
            odds.Clear();
        }
    }
}