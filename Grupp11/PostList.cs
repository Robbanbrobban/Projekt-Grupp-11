using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Grupp11
{


    public class PostList
    {
        private string textFile;

        public string TextFile
        {
            get
            {
                if (textFile == null)
                {
                    textFile = File.ReadAllText("postlist.txt");
                }
                return textFile;
            }
            set
            {
                textFile = value;
            }
        }
        public string title { get; set; }
        public string dateTime { get; set; }
        public string paragraph { get; set; }
        public string author { get; set; }

        public override string ToString()
        {
            return $"Datum: {dateTime}\t Författare: {author}\t Title: {title}\t Text: {paragraph}\t";

        }

    }
}



