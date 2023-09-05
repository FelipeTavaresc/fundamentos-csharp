using System;
using System.Threading;

namespace Stopwatch
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
            Console.WriteLine("S = Second => 10s = 10 seconds");
            Console.WriteLine("M = Minute => 1m = 1 minute");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("How many time do you would like to count?");
            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            Console.WriteLine(type);
        }
        static void Start(int time)
        {
            int currentTime = 0;
            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Stopwatch end");
            Thread.Sleep(2000);
        }
    }
}
