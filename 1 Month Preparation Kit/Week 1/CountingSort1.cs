using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] result = new int[100];

        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            result[input[i]]++;
        }

        Console.WriteLine(string.Join(" ", result));
    }
}