using System;
using System.Linq;

namespace Day7.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(string.Join(" ", array.Reverse()));
        }
    }
}