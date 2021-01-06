using System;
using System.Collections.Generic;

namespace Grupp11
{
    class PostTest
    {
        public static void ReadFile()
        {
            PostList list = new PostList();
            string [] lines = list.TextFile.Split('\t');
            foreach (string name in lines){
                Console.WriteLine(name);
            }
            {
                
            }
        }
    }
}
