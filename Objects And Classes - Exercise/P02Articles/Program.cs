using System;
using System.Collections.Generic;
using System.Linq;

namespace P02Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] aricleArgs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = aricleArgs[0];
            string content = aricleArgs[1];
            string author = aricleArgs[2];

            Article article = new Article(title, content, author);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commArgs = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = commArgs[0];
                string value = commArgs[1];

                if (command == "Edit")
                {
                    article.EditContent(value);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(value);
                }
                else if (command == "Rename")
                {
                    article.RenameArticle(value);
                }
            }
            Console.WriteLine(article.ToString());
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; private set; }

        public string Content { get; private set; }

        public string Author { get; private set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

        public void EditContent (string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor (string author)
        {
            this.Author = author;
        }

        public void RenameArticle (string title)
        {
            this.Title = title;
        }
    }
}
