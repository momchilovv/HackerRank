using System;
using System.Numerics;

namespace Day25.RunningTimeAndComplexity
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number == 1) return false;

            for (int i = 2; i <= Math.Sqrt(number); ++i)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (IsPrime(number) == true)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    Console.WriteLine("Not prime");
                }
            }
        }
    }
}