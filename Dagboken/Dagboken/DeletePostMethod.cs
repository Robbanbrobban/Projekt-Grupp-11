using System;
using System.Collections.Generic;

namespace Dagboken
{
    class DeletePostMethod
    {
        public static void DeletePosts()
        {
            //Console.WriteLine("Välj användare");
            Dagboken.NewPostMethods.ChooseAuthor();//skickar tillbaka fel lös
            Console.ReadLine();
            Console.WriteLine("Välj rubrik");
            Dagboken.PreviousPostsMethod.SortHeader();//skickar också tillbaka fel lös denna också
            Console.ReadLine();
            Console.WriteLine("Ta bort inlägg?");
            Console.ReadLine();
            Console.WriteLine("Är du säker på att du vill ta bort inlägget? ja/nej");
            Console.ReadLine();
            Dagboken.Program.MainMenu();
        }   
    }

}