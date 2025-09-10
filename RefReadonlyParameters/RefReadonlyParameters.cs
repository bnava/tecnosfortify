class C
{
    string M(in int i) => "C#12 output " + Environment.MachineName;
    static void Main()
    {
        int i = 5;
        System.Console.Write(new C().M(ref i));
    }
}
static class E
{
    public static string M(this C c, ref int i) => "C#11 output";
}