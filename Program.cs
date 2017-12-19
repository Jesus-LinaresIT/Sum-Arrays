using System;

internal class Solution
{
    private static void Main(string[] args)
    {
        var ar_temp = Console.ReadLine().Split(' ');
        var ar = Array.ConvertAll(ar_temp, int.Parse);
        var result = 0;

        for (var i = 0; i < ar.Length; i++)
            result = result + ar[i];

        Console.WriteLine(result);

        Console.ReadKey();
    }
}