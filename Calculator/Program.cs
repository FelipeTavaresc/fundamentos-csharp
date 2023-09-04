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

            Console.WriteLine(v1);
        }
    }
}
