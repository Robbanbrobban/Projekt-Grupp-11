using System;


namespace Grupp11
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
            Console.WriteLine("                      Hej och Välkommen till\r\n");
            Console.WriteLine(" █████  ██      ███████ ██   ██ ███████ ██ ███    ███ ███████ ██████  ");
            Console.WriteLine("██   ██ ██         ███  ██   ██ ██      ██ ████  ████ ██      ██   ██ ");
            Console.WriteLine("███████ ██        ███   ███████ █████   ██ ██ ████ ██ █████   ██████  ");
            Console.WriteLine("██   ██ ██       ███    ██   ██ ██      ██ ██  ██  ██ ██      ██   ██ ");
            Console.WriteLine("██   ██ ███████ ███████ ██   ██ ███████ ██ ██      ██ ███████ ██   ██ ");
            Console.WriteLine("\r\nDetta är ett verktyg för dig med Alzheimer att komma ihåg saker");
            Console.WriteLine("Tryck 1 för att starta verktyget.\r\nTryck 2 för att stänga av\r\n");

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
            Console.WriteLine("1) Inlägg");
            Console.WriteLine("2) Läs tidigare inlägg");
            Console.WriteLine("3) Sortera inlägg");
            Console.WriteLine("4) Ta bort Textfil");
            Console.WriteLine("5) Avslutar programmet");

            ConsoleKeyInfo input;
            input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                Post.NewPost();

            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                Reader.ReadFile();

            }
            else if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                SortMenu();

            }
            else if (input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                Post.RemoveText();

            }
            else if (input.Key == ConsoleKey.D5 || input.Key == ConsoleKey.NumPad5)
            {
                Console.Clear();
                ShutDown();
            }
            else SortMenu();

        }
        public static void SortMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Sök titel");
            Console.WriteLine("2) Sortera datum");
            Console.WriteLine("3) Skriv ut författare");
            Console.WriteLine("4) Gå tillbaka till huvudmenyn");



            ConsoleKeyInfo input;
            input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                Reader.SortTitle();

            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                Reader.SortDate();

            }
            else if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                Reader.SortAuthor();

            }
            else if (input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                MainMenu();

            }
            else
            {
                SortMenu();
            }
        }




        public static void ShutDown()
        {
            Console.WriteLine("Är du säker på att du vill avsluta programmet? tryck j=ja n=nej\nj/n");
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.J) 
            {
                Console.Clear();
                Console.WriteLine("Programmet Stängs av...");
                Environment.Exit(0);
            }
            else if (input.Key == ConsoleKey.N)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                ShutDown();
            }
        }
    }
}




