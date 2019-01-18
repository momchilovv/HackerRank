using System;
using System.Linq;

namespace Day20.Sorting
{
    class Program
    {
        static void swap(ref int firstPos,ref int secondPos)
        {
            int temp = firstPos;
            firstPos = secondPos;
            secondPos = temp;

        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int numberOfSwaps = 0;

            for (int i = 0; i < n; i++)
            {
                

                for (int j = 0; j < n - 1; j++)
                {
                    if (intArr[j] > intArr[j + 1])
                    {
                        swap(ref intArr[j],ref intArr[j + 1]);
                        numberOfSwaps++;
                    }
                }
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }
            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
            Console.WriteLine($"First Element: {intArr.First()}");
            Console.WriteLine($"Last Element: {intArr.Last()}");
        }
    }
}