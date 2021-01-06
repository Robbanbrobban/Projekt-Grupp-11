using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Projekt_test
{
    class Extra
    {
        public static readonly string MyTxt = "MyText.txt";
        public static void Extras()
        {
            string author;
            Console.WriteLine("Skriv ditt namn? ");
            author = Console.ReadLine();
            string path = MyTxt;
            using (StreamWriter sw = new StreamWriter(path,true))
            {
                if (File.Exists(MyTxt))
                {
                    sw.WriteLine("Skapades: {0}", DateTime.Now.ToString());
                    sw.WriteLine("Författare: {0}", author);
                    Console.WriteLine("Skriv din text annars....");
                    string text = Console.ReadLine();
                    if (text == "")
                    {
                        Save();
                    }
                    sw.WriteLine(text);
                    Extras();
                }
                else Extras();
            }
        }

        public static void Save()
        {
            Console.WriteLine("Fil Sparad");
        }
        // public static void ContinueOrSave()
        // { 

        //     Console.WriteLine("Vill du forsätta skriva? j/n");
        //     string answer = Console.ReadLine(); 
        //     answer = answer.ToUpper(); 
        //     // char a = Console.ReadKey();

        //     // if (answer == "J")
        //     // {
        //     //     Environment.NewLine;
        //     //     Console.Clear();
        //     //     Program.MainMenu();
        //     // }
        //     // else if(answer == "N")
        //     // {
        //     //     //spara i text
        //     // }
        //     // else ContinueOrSave();
        // }
    }
}