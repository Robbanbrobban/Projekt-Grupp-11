using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projekt_test
{
    class NewPosts
    {
        public static readonly string Txt = "Diary.txt";

        public static List<Posts> newPost = new List<Posts>();
        public static void NewPost()
        {
            // List<Posts> newPost = new List<Posts>();
            string path = Txt;
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                string datum = DateTime.Now.ToString();
                Console.WriteLine("Skriv in titel: ");
                string titel = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("Skriv in text: ");
                    string Text = Console.ReadLine();
                    // Console.WriteLine("Tryck enter ifall du vill du fortsätta skriva ?");
                    // Console.WriteLine("Tryck för att Avsluta?");

                    ConsoleKeyInfo input;
                    input = Console.ReadKey();
                    if (input.Key == ConsoleKey.Enter)
                    {

                        string newText = Console.ReadLine();
                        if (newText != "")
                        {
                            Text += newText;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
                    {
                        break;
                    }
                    else Save();
                }
            }
            //     newPost.Add(new Posts(titel, datum, Text));
            //     sw.WriteLine("Ny fil skapad: {0}", datum);
            //     sw.WriteLine("Rubrik: {0}", titel);
            //     sw.WriteLine("Text: {0} {1}", Text);
            // }
            // Console.WriteLine("Texten har sparats");
            // Program.MainMenu();
            // foreach (var a in newPost)
            // {
            //     Console.WriteLine("Datum: {0}\nRubrik: {1}\nText: {2}", a.dateTime, a.title, a.text);
            // }
        }
        public static void Save()
        {
            Console.WriteLine("Fil Sparad");
        }
        //    public static void PostTest()
        //     {
        //         string text = "First line" + Environment.NewLine;
        //         File.WriteAllText(Path.Combine("WriteFile.txt"), text);
        //         string[] lines = {"New line 1", "New line2"};
        //         File.AppendAllLines(Path.Combine("writeFile.txt"), lines);
        //     }
    }
}