using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        long[] numbers = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();

        Console.WriteLine($"{numbers.Sum() - numbers.Last()} {numbers.Sum() - numbers[0]}");
    }
}