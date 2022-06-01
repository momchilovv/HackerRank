using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        decimal[] numbers = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
        
        decimal positive = 0, negative = 0, zero = 0;

        foreach (var item in numbers)
        {
            if (item < 0)
            {
                negative++;
            }
            else if (item > 0)
            {
                positive++;
            }
            else if (item == 0)
            {
                zero++;
            }
        }

        Console.WriteLine($"{positive / numbers.Length:f6}\r\n{negative / numbers.Length:f6}\r\n{zero / numbers.Length:f6}\r\n");
    }
}