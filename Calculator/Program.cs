using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;
            Console.WriteLine($"The result of sum is: {result}");
        }
    }
}
