using System;

class Program
{
    static void Main(string[] args)
    {
        int queries = int.Parse(Console.ReadLine());
        long[] numbers = new long[queries];
        long parameter = 0b11111111111111111111111111111111L;

        for (int i = 0; i < queries; i++)
        {
            long input = long.Parse(Console.ReadLine());
            numbers[i] = (~input & parameter);
        }
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}