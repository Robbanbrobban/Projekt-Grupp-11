using System.Collections.Generic;
using System;
using System.IO;
using System.Text.Json;

namespace Grupp11
{
    class Post
    {
        private string FileName = "postlist.json";
        public static List<Posts> PostList;
        public Post()
        {
            PostList = new List<Posts>();
        }
        public void AddPost(Posts list)
        {
            PostList.Add(list);
        }
        public void ReadFile()
        {
            if (PostList.Count == 0)
            {
                Console.WriteLine("Finns inga inlägg, skriv ett inlägg först för att kunna läsa/sortera inlägg.");
            }
            for (int i = 0; i < PostList.Count; i++)
            {
                PostList[i].WritePosts();
                Console.WriteLine();
            }
            Console.WriteLine("Tryck på en knapp för att gå tillbaka till Menyn");
            Console.ReadKey();
            Program.MainMenu();
        }
        public List<Posts> FoundTitle(string title)
        {
            List<Posts> findTitle = new List<Posts>();
            for (int i = 0; i < PostList.Count; i++)
            {
                if (PostList[i].title.ToLower().Contains(title.ToLower()))
                {
                    findTitle.Add(PostList[i]);
                }
            }
            return findTitle;
        }
        public void SortDate()
        {
            PostList.Sort(Posts.Datecompare);
            ReadFile();
        }
        public void SortDateReverse()
        {
            PostList.Sort(Posts.ReverseDate);
            ReadFile();
        }
        public List<Posts> FoundAuthor(string author)
        {
            List<Posts> findauthor = new List<Posts>();
            for (int i = 0; i < PostList.Count; i++)
            {
                if (PostList[i].author.ToLower().Contains(author.ToLower()))
                {
                    findauthor.Add(PostList[i]);
                }
            }
            return findauthor;
        }
        public void JsonSave()
        {
            if (PostList.Count > 0)
            {
                string jsonSaveText = JsonSerializer.Serialize(PostList);
                File.WriteAllText(FileName, jsonSaveText);
            }
        }
        public void JsonLoad()
        {
            if (File.Exists(FileName))
            {
                string jsonSaveText = File.ReadAllText(FileName);
                List<Posts> jsonDeText = JsonSerializer.Deserialize<List<Posts>>(jsonSaveText);
                PostList = jsonDeText;
            }
        }
    }
}