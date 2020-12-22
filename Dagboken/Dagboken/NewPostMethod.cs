using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dagboken
{
    class NewPostMethods
    {
        public static List<Authors> authordata = new List<Authors>();
        public static void NewPost()
        {
            Console.Clear();
            Console.WriteLine("1) Välj Författare\n2) Ny Författare\n3) Gå Tillbaka");
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                AuthorMenu();

            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                newAuthor();
            }
            else if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                Dagboken.Program.MainMenu();

            }
            else NewPost();

        }
        public static void AuthorMenu()
        {

            Console.Clear();
            ChooseAuthor();
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                newAuthor();

            }
            else AuthorMenu();
        }
        public static void newAuthor()
        {
            Authors author = new Authors();
            Console.WriteLine("Skapa ny författare");
            Console.WriteLine("Skriv in ditt förnamn");
            author.foreName = Console.ReadLine();
            Console.WriteLine("Skriv in ditt efternamn");
            author.lastName = Console.ReadLine();
            Console.WriteLine("Användaren {0} {1} har skapats", author.foreName, author.lastName);
            authordata.Add(author);
            NewPost();
        }
        public static void ChooseAuthor()//Här ska listan in sen så man kan välja författare efter namn
        {
            Console.WriteLine("Välj författare från listan:\n");//har skall vi skapa en Lista som sedan skall skriva ut alla författare med index
            int user = 0;
            foreach (Authors a in authordata)
            {
                Console.WriteLine(a);
            }
            user = Int32.Parse(Console.ReadLine());
            CreateHeader();
        }
        public static void CreateHeader()
        {
            string header;
            Console.WriteLine("Skriv din Rubrik");//skall sparas in i en txt file som rubrik.
            header = Console.ReadLine();
            CreateText();
        }
        
        public static void CreateText()//skall sparas tillsammans med rubrik. Datum ska även sparas med när du sparar.
        {
            string text;
            Console.WriteLine("Skriv din text här");
            text = Console.ReadLine();
            SaveText();
        }

        public static void SaveText()//funktionen som skall spara text och rubrik i någon form av savefil.
        {
            Console.WriteLine("Din Text har sparats!\nTryck enter för att komma tillbaka till nya inlägg");
            Console.ReadLine();
            NewPost();//eventuellt byta till SortHeader
        }
    }
}