using System;

namespace Grupp11
{
    public class Posts
   
    {
        private static Post CheckFileExistence;
        public string title { get; set; }
        public DateTime PostTime { get; set; }
        public string paragraph { get; set; }
        public string author { get; set; }
        public Posts(string Title, string Author, string Paragraph)
        {
            this.PostTime = DateTime.Now;
            this.title = Title;
            this.author = Author;
            this.paragraph = Paragraph;
        }
        public Posts()
        {
            this.PostTime = DateTime.Now;
            this.title = "";
            this.author = "";
            this.paragraph = "";
        }
        public void WritePosts()
        {
            Console.WriteLine($"Datum: {PostTime}\nFörfattare: {author}\nTitle: {title}\nText: {paragraph}\n");
        }
        public void WritePostsDate()
        {
            Console.WriteLine($"Datum: {PostTime}\tFörfattare: {author}\tTitle: {title}\tText: {paragraph}\t");
        }
        public static int Datecompare(Posts postA, Posts postB)
        {
            int value = postA.PostTime.CompareTo(postB.PostTime);
            if (value == 1)
            {
                return -1;
            }
            if (value == -1)
            {
                return 1;
            }
            return 0;
        }
        public static int ReverseDate(Posts postA, Posts postB)
        {
            return postA.PostTime.CompareTo(postB.PostTime);
        }

    }
}