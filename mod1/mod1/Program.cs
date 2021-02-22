using System;

namespace mod1
{
    class Program
    {
        static void Main(string[] args)
        {
        int a = SumOfThreeVariables(500, 200, 300);

        Console.WriteLine(a);
        }
    static int SumOfThreeVariables(int value1, int value2, int value3)
    {
        int result = 0;

        result = value1 + value2 + value3;

        return result;
    }
}
}
