using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projekt_test
{
    class Program
    {
       static void Main(string[] args)
        {
            WelcomeMenu();

        }

        public static void WelcomeMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine("Hej och Välkommen till\r\n");
            Console.WriteLine(" █████  ██      ███████ ██   ██ ███████ ██ ███    ███ ███████ ██████  ");
            Console.WriteLine("██   ██ ██         ███  ██   ██ ██      ██ ████  ████ ██      ██   ██ ");
            Console.WriteLine("███████ ██        ███   ███████ █████   ██ ██ ████ ██ █████   ██████  ");
            Console.WriteLine("██   ██ ██       ███    ██   ██ ██      ██ ██  ██  ██ ██      ██   ██ ");
            Console.WriteLine("██   ██ ███████ ███████ ██   ██ ███████ ██ ██      ██ ███████ ██   ██ ");
            Console.WriteLine("\r\nDetta är ett verktyg för dig med Alzheimer att komma ihåg saker");
            Console.WriteLine("Tryck 1 för att starta\r\nTryck 2 för att stänga av\r\n");

            ConsoleKeyInfo input;
            input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                MainMenu();
            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                Console.WriteLine("Programmet Stängs av...");
                Environment.Exit(0);
            }
            else WelcomeMenu();

        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Nytt inlägg");
            Console.WriteLine("2) Läs tidigare inlägg");
            Console.WriteLine("3) Extra");
            Console.WriteLine("4) Skapa text och författare");
            Console.WriteLine("5) Avslutar programmet");

            ConsoleKeyInfo input;
            input = Console.ReadKey();
                
            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                NewPosts.NewPost();

            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                Reader.Read();

            }
            else if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                Extra.Extras();

            }
            else if (input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                Extra.Extras();

            }
            else if (input.Key == ConsoleKey.D5 || input.Key == ConsoleKey.NumPad5)
            {
                Console.Clear();
                Console.WriteLine("Programmet Stängs av...");
                Environment.Exit(0);
            }
            else MainMenu();
            
        }        

    }
}

