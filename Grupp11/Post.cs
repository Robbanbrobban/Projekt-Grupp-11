using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Grupp11
{
    class Post
    {
        public static List<PostList> lists = new List<PostList>();
        public static void NewPost()
        {
            string path = "postlist.txt";
            PostList list = new PostList();

            list.dateTime = DateTime.Now.ToString();
            Console.Write("Författare: ");
            list.author = Console.ReadLine();
            Console.Write("Skriv titel: ");
            list.title = Console.ReadLine();
            string space = "\t";
            string text;
            lists.Add(list);
            Console.WriteLine("Tryck på enter för ny rad.\nTryck på enter 2 gånger för att spara.");
            Console.Write("Skriv din text:");
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
            Console.WriteLine("Tryck Enter för att komma tillbaka.");
            Console.ReadKey();
            Program.MainMenu();
        }
        public static void RemoveText()
        {
            Console.WriteLine("Är du säker på att du vill ta bort txt filen? j/n");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "J")
            {
                File.Delete("postlist.txt");
                Console.Clear();
            }
            else if (answer == "N")
            {
                Console.Clear();
                return;
            }
            Program.MainMenu();
        }
    }
}


