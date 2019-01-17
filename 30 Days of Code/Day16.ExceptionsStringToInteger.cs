using System;

namespace Day16.ExceptionsStringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(str));
            }
            catch (FormatException)
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}