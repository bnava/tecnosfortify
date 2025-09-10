using System;

class Program
{
    static void Main()
    {
        var addWithDefault = (int addTo = 2) => addTo + Environment.ProcessId;

        int result = addWithDefault(); 

        Console.WriteLine("Result: " + result);
    }
}
