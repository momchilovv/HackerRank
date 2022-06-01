using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int leftToRight = 0, rightToLeft = 0;

        for (int i = 0, j = n - 1; i < n; i++, j--)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            leftToRight += input[i];
            rightToLeft += input[j];
        }
        Console.WriteLine(Math.Abs(leftToRight - rightToLeft));
    }
}