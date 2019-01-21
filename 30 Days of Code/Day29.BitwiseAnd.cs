using System;
using System.Linq;

namespace Day29.BitwiseAnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int maximumPossible = 0;

            for (int i = 0; i < t; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int n = input[0];
                int k = input[1];

                for (int h = 1; h <= n; h++)
                {
                    for (int j = h + 1; j <= n; j++)
                    {
                        int ab = h & j;

                        if (maximumPossible < ab && ab < k)
                        {
                            maximumPossible = ab;
                        }
                    }
                }
                Console.WriteLine(maximumPossible);
                maximumPossible = 0;
            }
        }
    }
}