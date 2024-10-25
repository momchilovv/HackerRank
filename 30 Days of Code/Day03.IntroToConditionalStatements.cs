using System;

namespace Day3.IntroToConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isOdd = n % 2 == 1;

            if (isOdd)
            {
                Console.WriteLine("Weird");
            }
            else if (!isOdd && n >= 2 && n <= 5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (!isOdd && n >= 6 && n <= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (!isOdd && n > 20)
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}