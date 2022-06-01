using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        int[] input = Console.ReadLine().Split().Select(int.Parse).GroupBy(x => x).Where(n => n.Count() == 1).Select(y => y.Key).ToArray();

        Console.WriteLine(input.Last());
    }
}