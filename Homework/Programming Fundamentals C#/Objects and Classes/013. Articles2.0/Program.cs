using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            List<Article> ListOfArticles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string title = data[0];
                string content = data[1];
                string author = data[2];

                var newArticle = new Article();
                newArticle.Title = title;
                newArticle.Content = content;
                newArticle.Author = author;

                ListOfArticles.Add(newArticle);
            }

            Console.WriteLine(string.Join(Environment.NewLine, ListOfArticles));


        }


        public class Article
        {
            public object Title { get; set; }
            public object Content { get; set; }
            public object Author { get; set; }


            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }


        }
    }
}