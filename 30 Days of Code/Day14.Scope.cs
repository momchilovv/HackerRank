using System;
using System.Linq;

namespace Day14.Scope
{
    class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elements)
        {
            this.elements = elements;
        }

        public void computeDifference()
        {
            int maximum = elements.Max();
            int minimum = elements.Min();

            maximumDifference = maximum - minimum;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int.Parse(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            Difference d = new Difference(a);
            d.computeDifference();
            Console.WriteLine(d.maximumDifference);
        }
    }
}