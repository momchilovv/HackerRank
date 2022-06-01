using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] strings = new string[n];

        for (int i = 0; i < n; i++)
        {
            strings[i] = Console.ReadLine();
        }

        int q = int.Parse(Console.ReadLine());
        string[] queries = new string[q];
        int[] results = new int[q];

        for (int i = 0; i < q; i++)
        {
            queries[i] = Console.ReadLine();
        }
        for (int i = 0; i < queries.Length; i++)
        {
            foreach (var str in strings)
            {
                if (queries[i] == str)
                {
                    results[i]++;
                }
            }
        }
        foreach (var occ in results)
        {
            Console.WriteLine(occ);
        }
    }
}