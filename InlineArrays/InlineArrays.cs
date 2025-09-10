using System;

[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer
{
    private int _element0;
}

public class Program
{
    public static void Main()
    {
        var buffer = new Buffer();
        buffer[1] = Environment.ProcessId;
        buffer[2] = 15;

        foreach (var i in buffer)
        {
            Console.WriteLine(i);
        }
    }
}
