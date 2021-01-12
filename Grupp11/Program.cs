using System;
using System.Collections.Generic;
using System.IO;


namespace Grupp11
{
    class Program
    {
        private static Post AllPosts;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            WelcomeMenu();
        }
        public static void WelcomeMenu()
        {
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
            AllPosts = new Post();
            AllPosts.JsonLoad();
            Console.Clear();
            Console.WriteLine("1) Inlägg");
            Console.WriteLine("2) Läs tidigare inlägg");
            Console.WriteLine("3) Sök/sortera inlägg");
            Console.WriteLine("4) Ta bort Textfil");
            Console.WriteLine("5) Avslutar programmet");

            ConsoleKeyInfo input;
            input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                NewPost();
            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                AllPosts.ReadFile();
            }
            else if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                SearchMenu();
            }
            else if (input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                RemoveText();
            }
            else if (input.Key == ConsoleKey.D5 || input.Key == ConsoleKey.NumPad5)
            {
                Console.Clear();
                ShutDown();
            }
            else SearchMenu();
        }
        public static void SearchMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Sök titel");
            Console.WriteLine("2) Sök författare");
            Console.WriteLine("3) Sortera och lista datum");
            Console.WriteLine("4) Gå tillbaka till huvudmenyn");

            ConsoleKeyInfo input;
            input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                SearchTitle();
            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                SearchAuthor();
            }
            else if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                SortMenu();
            }
            else if (input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                SearchMenu();
            }
        }
        public static void SortMenu()
        {
            Console.Clear();
            Console.WriteLine("1) Sortera nyast till äldst");
            Console.WriteLine("2) Sortera äldst till nyast");
            Console.WriteLine("3) Gå tillbaka till menyn");
            ConsoleKeyInfo input;
            input = Console.ReadKey();

            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                AllPosts.SortDate();
            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                AllPosts.SortDateReverse();
            }
            else if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                MainMenu();
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
        public static string CheckInput(string hej)
        {
            string text = hej;
            do
            {
                if (text == "")
                {
                    Console.WriteLine("Du skrev inte in något försök igen");
                    text = Console.ReadLine();
                }
            }
            while (string.IsNullOrEmpty(text));
            return text;
        }

        public static void NewPost()
        {
            Console.WriteLine("Tryck Escape för att gå tillbaka till menyn\nTryck på en knapp för att börja skriva");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            if (consoleKeyInfo.Key == ConsoleKey.Escape)
            {
                MainMenu();
            }
            Console.Clear();
            Console.Write("Författare: ");
            string author = Console.ReadLine();
            CheckInput(author);
            Console.Write("Skriv titel: ");
            string title = Console.ReadLine();
            CheckInput(title);
            string space = "\t";
            string text;
            Console.WriteLine("Tryck på enter för ny rad.\nTryck på enter 2 gånger för att spara.");
            Console.Write("Skriv din text:\n");
            text = Console.ReadLine();
            text += space;

            while (true)
            {
                string text1 = Console.ReadLine();
                if (text1 == "")
                {
                    break;
                }
                text += text1 += space;
            }
            AllPosts.AddPost(new Posts(title, author, text));
            Console.Clear();
            Console.WriteLine("Inlägg skapades: {0}\nFörfattare: {1}\nTitel: {2}\nText:\n{3}", DateTime.Now.ToString(), author, title, text);
            AllPosts.JsonSave();
            Console.WriteLine("Tryck på en knapp för att komma tillbaka.");
            Console.ReadKey();
            MainMenu();
        }
        public static void RemoveText()
        {
            Console.WriteLine("Är du säker på att du vill ta bort txt filen? j/n");
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.J)
            {
                File.Delete("postlist.json");
                Console.Clear();
            }
            else if (input.Key == ConsoleKey.N)
            {
                Console.Clear();
                MainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Försök igen: ");
                RemoveText();
            }
            MainMenu();
        }
        private static void SearchTitle()
        {
            Console.Write("Skriv titeln du vill söka på: ");
            string title = Console.ReadLine();
            List<Posts> findTitle = AllPosts.FoundTitle(CheckInput(title));
            if (findTitle.Count == 0)
            {
                Console.WriteLine("Finns inga sparade inlägg");
            }
            else
            {
                for (int i = 0; i < findTitle.Count; i++)
                {
                    findTitle[i].WritePosts();
                }
            }
            Console.Write("Tryck på en knapp för att gå tillbaka till menyn");
            Console.ReadKey();
            SearchMenu();
        }
        private static void SearchAuthor()
        {
            Console.Write("Skriv författaren du vill söka på: ");
            string author = Console.ReadLine();
            List<Posts> findAuthor = AllPosts.FoundAuthor(CheckInput(author));
            if (findAuthor.Count == 0)
            {
                Console.WriteLine("Finns inga sparade inlägg");
            }
            else
            {
                for (int i = 0; i < findAuthor.Count; i++)
                {
                    findAuthor[i].WritePosts();
                }
            }
            Console.WriteLine("Tryck på en knapp för att gå tillbaka till menyn");
            Console.ReadKey();
            SearchMenu();
        }
    }
}








