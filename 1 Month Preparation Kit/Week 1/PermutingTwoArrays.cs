using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int queries = int.Parse(Console.ReadLine());
        string[] result = new string[queries];

        for (int i = 0; i < queries; i++)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = arr[0], k = arr[1];

            int[] a = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(x => x).ToArray();

            for (int j = 0; j < a.Length; j++)
            {
                if (a[j] + b[j] >= k )
                {
                    result[i] = "YES";
                }
                else
                {
                    result[i] = "NO";
                    break;
                }
            }
        }
        Console.WriteLine(string.Join("\r\n", result));
    }
}