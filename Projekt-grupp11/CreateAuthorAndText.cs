using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Projekt_test
{

    class CreateAuthor
    {
        public static readonly string text = "{0}MyText.txt", author;

        public static void CreateAuthors()
        {
            string path = text;
            string author;
            Console.WriteLine("Skriv ditt namn? ");
            author = Console.ReadLine();
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                    sw.WriteLine("Skapades: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Författare: {0}", author);
                    Console.WriteLine("Skriv din text annars....");
                    string text = Console.ReadLine();
            }
        }
    }
}