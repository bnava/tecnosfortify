using System;

public class Program
{
    public static void Main()
    {
        C myStruct = new C();
        myStruct.P = Environment.MachineName;

        string propertyName = C.M1();
        string propertyValue = myStruct.P;
        int stringLength = myStruct.P.Length;

        Console.WriteLine($"Property name: {propertyName}");

        if(propertyName == "Length")
        {
            Console.WriteLine($"Property value: {propertyValue}");
            Console.WriteLine($"Property value: {stringLength}");
        }
    }
}

public struct C
{
    public string P;
    public static string M1() => nameof(P.Length);
}
