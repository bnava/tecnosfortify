using T = System.Int32;

class Program
{
    static void Main()
    {
        T number1 = 42;
        T number2 = Environment.ProcessId;
        T sum = AddNumbers(number1, number2);

        Console.WriteLine($"The sum of {number1} and {number2} is {sum}.");
    }

    static T AddNumbers(T a, T b)
    {
        return a + b;
    }
}
