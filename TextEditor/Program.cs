using System;
using System.IO;
using System.Net;

namespace TextEditor
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
            Console.WriteLine("What you would like to do?");
            Console.WriteLine("1 - Open file");
            Console.WriteLine("2 - Create new file");
            Console.WriteLine("0 - Exit");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {

        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Insert your text below (ESC to exit)");
            Console.WriteLine("----------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("What's path to save the file?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"File saved {path} succeed");
            Console.ReadLine();
            Menu();
        }
    }
}
