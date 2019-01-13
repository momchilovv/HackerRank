using System;

namespace Day2.Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = double.Parse(Console.ReadLine());

            double tipPercent = double.Parse(Console.ReadLine());
                              
            double taxPercent = double.Parse(Console.ReadLine());

            double tip = (mealCost / 100) * tipPercent;
            
            double tax = (mealCost / 100) * taxPercent;

            double totalCost = mealCost + tax + tip;

            Console.WriteLine((int)Math.Round(totalCost));
        }
    }
}
