using System;

namespace Day10.BinaryNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(n, 2);

            int count = 0;
            int longestSequence = 0;

            foreach (var item in binary)
            {
                if (item == '1')
                {
                    count++;
                    if (count > longestSequence)
                    {
                        longestSequence = count;
                    }
                }
                else if (item == '0')
                {
                    if (count > longestSequence)
                    {
                        longestSequence = count;
                    }
                    count = 0;

                }
            }
            Console.WriteLine(longestSequence);
        }
    }
}