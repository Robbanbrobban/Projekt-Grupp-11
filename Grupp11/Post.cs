using System;
using System.Collections.Generic;
using System.IO;



namespace Grupp11
{
    class Post
    {
        public static List<PostList> lists = new List<PostList>();
        public static PostList list = new PostList();
        public static void NewPost()
        {
            Console.WriteLine("Tryck Escape för att gå tillbaka till menyn\nTryck på en knapp för att börja skriva");
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            Console.Clear();
            if(consoleKeyInfo.Key == ConsoleKey.Escape)
            {
                Program.MainMenu();
            }
            string path = "postlist.txt";
            list.dateTime = DateTime.Now.ToString();
            Console.Write("Författare: ");
            list.author = Console.ReadLine();
            Console.Write("Skriv titel: ");
            list.title = Console.ReadLine();
            string space = "\t";
            string text;
            lists.Add(list);
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
            list.paragraph = text;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                Console.WriteLine("Inlägg skapades: {0}\tTitel: {1}\tText:\t{2}", list.dateTime, list.title, list.paragraph);
                sw.WriteLine("Datum: {0}\tFörfattare: {1}\tTitel: {2}\tText:\t{3}", list.dateTime, list.author, list.title, list.paragraph);
            }
            Console.WriteLine("Tryck på en knapp för att komma tillbaka.");
            Console.ReadKey();
            Program.MainMenu();
        }
        public static void RemoveText()
        {
            Console.WriteLine("Är du säker på att du vill ta bort txt filen? j/n");
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.J) 
            {
                File.Delete("postlist.txt");
                Console.Clear();
            }
            else if (input.Key == ConsoleKey.N)
            {
                Console.Clear();
                Program.MainMenu();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Försök igen: ");
                RemoveText();
            }
            Program.MainMenu();
        }
    }
}


