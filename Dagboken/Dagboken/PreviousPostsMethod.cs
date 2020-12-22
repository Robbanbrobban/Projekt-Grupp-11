using System;
using System.Collections.Generic;

namespace Dagboken
{
    class PreviousPostsMethod
    {
        public static void PreviousPosts()
        {
            Console.Clear();
            Console.WriteLine("1) Sortera inlägg efter datum\n2) Listar rubriker i ordning\n3) Sök rubrik\n4) Gå Tillbaka");
            ConsoleKeyInfo input;
            input = Console.ReadKey();
            if (input.Key == ConsoleKey.D1 || input.Key == ConsoleKey.NumPad1)
            {
                Console.Clear();
                SortHeaderDate();

            }
            else if (input.Key == ConsoleKey.D2 || input.Key == ConsoleKey.NumPad2)
            {
                Console.Clear();
                SortHeader();
            }
            else if (input.Key == ConsoleKey.D3 || input.Key == ConsoleKey.NumPad3)
            {
                Console.Clear();
                SearchHeader();

            }
            else if (input.Key == ConsoleKey.D4 || input.Key == ConsoleKey.NumPad4)
            {
                Console.Clear();
                Dagboken.Program.MainMenu();
            }
            else PreviousPosts();
        }
        public static void SortHeaderDate()//lägga till knapp för att kunna gå tillbaka tex tryck enter två ggr.
        {
            Console.WriteLine("Sorterar Lista och skriver ut lista efter datum");
            Console.ReadLine();
            PreviousPosts();
        }
        public static void SortHeader()
        {
            Console.WriteLine("Sorterar lista i Bokstavsordning");
            Console.ReadLine();
            PreviousPosts();
        }
        public static void SearchHeader()
        {
            Console.WriteLine("Här kan du söka efter rubrik");
            Console.ReadLine();
            PreviousPosts();
        }
    }
}