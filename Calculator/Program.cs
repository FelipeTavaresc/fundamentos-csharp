using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum();
            Subtraction();
        }

        static void Sum()
        {
            Console.Clear();
            Console.Write("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;
            Console.WriteLine($"The result of sum is: {result}");
            Console.ReadKey();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.Write("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 - v2;
            Console.WriteLine($"The result of subtraction is: {result}");
            Console.ReadKey();
        }
    }
}
