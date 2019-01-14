using System;
using System.Linq;

namespace Day11._2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                array[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            int[] arraySum = new int[16];

            int hourglass = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arraySum[hourglass] = array[i][j] + array[i][j + 1] + array[i][j + 2]
                            + array[i + 1][j + 1] + array[i + 2][j] + array[i + 2][j + 1]
                            + array[i + 2][j + 2];
                    hourglass++;
                }
            }

            Array.Sort(arraySum);
            Console.WriteLine(arraySum[15]);
        }
    }
}