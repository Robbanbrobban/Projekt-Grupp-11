using System;
using System.IO;


namespace Grupp11
{
    class Reader
    {

        public static void ReadFile()
        {
            CreateNewTextFile();
            PostList list = new PostList();
            string[] lines = list.TextFile.Split('\t');
            foreach (string name in lines)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Tryck på en knapp för att gå tillbaka till Menyn");
            Console.ReadKey();
            Grupp11.Program.MainMenu();
        }
        public static void SortTitle()
        {
            CreateNewTextFile();
            PostList list = new PostList();
            int braTitel = 0;
            string[] lines = list.TextFile.Split('\t');
            Console.WriteLine("Skriv titeln du vill söka på");
            string titelSok = Console.ReadLine();
            for (int i = 0; i < lines.Length; i++)
            {
                string temp = lines[i];
                if (temp.Contains(titelSok) == true && temp.Contains("Titel: ") == true)
                {
                    Console.WriteLine(lines[i - 2]);
                    Console.WriteLine(lines[i - 1]);
                    Console.WriteLine(temp);
                    braTitel = 1;
                }

            }
            if (braTitel == 1)
            {
                Console.WriteLine("Tryck på en knapp för att gå tillbaka till Menyn");
                Console.ReadKey();
                Program.MainMenu();
                braTitel = 0;
            }
            else
            {
                Console.WriteLine("Titeln du sökte finns inte");
                Console.WriteLine("Tryck på en knapp för att gå tillbaka till Menyn");
                Console.ReadKey();
                Program.MainMenu();
            }

        }
        public static void SortDate()
        {

            PostList list = new PostList();
            int braDatum = 0;
            string[] lines = list.TextFile.Split('\r', '\n');
            string[] dateSort = new string[lines.Length];
            for (int i = 0; i <= lines.Length - 1; i++)
            {
                string temp = lines[i];
                if (temp.Contains("Datum:") == true)
                {
                    dateSort[i] = temp;
                }
                braDatum = 1;
            }
            if (braDatum == 1)
            {
                Array.Sort(dateSort);
                for (int i = 0; i <= dateSort.Length - 1; i++)
                {
                    if ((dateSort[i]) != null)
                    {
                        Console.WriteLine(dateSort[i]);
                    }

                }
                Console.WriteLine("Tryck på en knapp för att gå tillbaka till Menyn");
                Console.ReadKey();
                Program.MainMenu();
                braDatum = 0;
            }
            else
            {
                Console.WriteLine("Det finns inga datum i listan");
                Console.WriteLine("Tryck på en knapp för att gå tillbaka till Menyn");
                Console.ReadKey();
                Program.MainMenu();
            }

        }
        public static void SortAuthor()
        {
            CreateNewTextFile();
            PostList list = new PostList();
            int braForfattare = 0;
            string[] lines = list.TextFile.Split('\t');
            Console.WriteLine("Lista på författare");
            for (int i = 0; i < lines.Length; i++)
            {
                string temp = lines[i];
                if (temp.Contains("Författare: ") == true)
                {
                    Console.WriteLine(temp);
                    braForfattare = 1;
                }

            }
            if (braForfattare == 1)
            {
                Console.WriteLine("\nTryck på en knapp för att gå tillbaka till Menyn");
                Console.ReadKey();
                Program.MainMenu();
                braForfattare = 0;
            }
            else
            {
                Console.WriteLine("Det finns inga författare");
                Console.WriteLine("Tryck på en knapp för att gå tillbaka till Menyn");
                Console.ReadKey();
                Program.MainMenu();
            }


        }
        public static void CreateNewTextFile()
        {
            string path = "postlist.txt";
            using (StreamWriter sw = new StreamWriter(path, true))
            {

            }
            Console.WriteLine("Här var det tomt, skapar en ny textfil");
        }
    }

}

