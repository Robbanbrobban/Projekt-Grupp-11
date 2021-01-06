using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Projekt_test
{
    class Reader
    {
        public static void Read()
        {
            using (StreamReader sr = new StreamReader(NewPosts.Txt))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.ReadKey();
            Program.MainMenu();
        }
    }
}