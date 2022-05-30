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
            string[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();
            int n = int.Parse(Console.ReadLine());

            Article article = new Article(input[0], input[1], input[2]);
            

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries).ToArray(); 

                if (command[0] == "Edit")
                {
                    article.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                } 
                else if (command[0] == "Rename")
                {
                    article.Rename(command[1]);
                }
            }
             
            Console.WriteLine(article.ToString());
           

        }
    }
    public class Article
    {
        public static string Title { get; set; }
        public static string Content { get; set; }
        public static string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Article.Title = title;
            Article.Content = content;
            Article.Author = author;
        } 

        public void Edit (string content) 
        {
            Content = content;
        } 
        public void ChangeAuthor (string author)
        {
            Author = author; 
        } 
        public void Rename (string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}