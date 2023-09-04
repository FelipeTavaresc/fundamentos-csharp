using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What you would do like to do?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");

            Console.WriteLine("---------------------------------");
            Console.Write("Select one option: ");
            short result = short.Parse(Console.ReadLine());
            switch (result)
            {
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                default: Menu(); break;
            }
        }

        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("** Sum Operation ***");
            Console.Write("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 + v2;
            Console.WriteLine($"The result of sum is: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("** Subtraction Operation ***");
            Console.Write("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 - v2;
            Console.WriteLine($"The result of subtraction is: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("** Division Operation ***");
            Console.Write("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 / v2;
            Console.WriteLine($"The result of division is: {result}");
            Console.ReadKey();
            Menu();
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("** Multiplication Operation ***");
            Console.Write("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.Write("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float result = v1 * v2;
            Console.WriteLine($"The result of multiplication is: {result}");
            Console.ReadKey();
            Menu();
        }
    }
}
