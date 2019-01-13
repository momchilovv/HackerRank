using System;

namespace Day9.Recursion3
{
    class Program
    {
        static int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Factorial(n);

            Console.WriteLine(Factorial(n));
        }
    }
}