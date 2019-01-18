using System;

namespace Day21.Generics
{
    class Program
    {
        private static void PrintArray<T>(T[] stringArray)
        {
            foreach (var item in stringArray)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                intArray[i] = int.Parse(Console.ReadLine());
            }

            n = int.Parse(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            PrintArray<int>(intArray);
            PrintArray<string>(stringArray);
        }
    }
}