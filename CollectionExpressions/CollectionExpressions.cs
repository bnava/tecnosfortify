using System;

class Program
{
    static void Main()
    {
        int[] row0 = [1, 2, 3];
        int[] row1 = [4, 5, 6];
        int[] row2 = [7, 8, Environment.ProcessId];
        int[] single = [.. row0, .. row1, .. row2];
        foreach (var element in single)
        {
            Console.Write($"{element}, ");
        }
    }
}