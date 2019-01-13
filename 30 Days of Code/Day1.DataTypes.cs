using System;

namespace Day1.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenI = 4;
            double givenD = 4.0;
            string givenS = "HackerRank";

            int inputI = int.Parse(Console.ReadLine());
            double inputD = double.Parse(Console.ReadLine());
            string inputS = Console.ReadLine();

            Console.WriteLine(givenI + inputI);
            Console.WriteLine(givenD + inputD);
            Console.WriteLine(givenS + " " + inputS);
        }
    }
}