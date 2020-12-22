using System;
using System.Collections.Generic;

namespace Dagboken
{
    class AuthorMethod
    {
        public static void Authors()
        {
            Console.WriteLine("Skriver ut alla författare");
            Console.ReadLine();
            Dagboken.Program.MainMenu();
        }
    }

}