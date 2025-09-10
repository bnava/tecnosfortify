using System;
public class C(int i, string s)
{
    public int I { get; set; } = i;
    public string S { get; set; } = s;
}
class Program
{
    static void Main(string[] args)
    {
        var output = new C(10, Environment.MachineName);

        Console.WriteLine($"I: {output.I}");
        Console.WriteLine($"S: {output.S}");
    }
}