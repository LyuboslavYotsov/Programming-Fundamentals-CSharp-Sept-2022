using System;
using System.Collections.Generic;
using System.Linq;

namespace P02Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int articlesNum = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < articlesNum; i++)
            {
                string[] commArgs = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = commArgs[0];
                string content = commArgs[1];
                string author = commArgs[2];
                Article currArticle = new Article (title, content, author);
                articles.Add(currArticle);
            }
            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
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
    }
}
