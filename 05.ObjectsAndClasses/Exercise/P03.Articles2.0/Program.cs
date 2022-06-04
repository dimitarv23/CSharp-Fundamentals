using System;
using System.Collections.Generic;

namespace P03.Articles2._0
{
    class Article
    {
        public Article(string ttl, string ctn, string ath)
        {
            this.Title = ttl;
            this.Content = ctn;
            this.Author = ath;
        }
        public Article()
        {
            this.Title = string.Empty;
            this.Content = string.Empty;
            this.Author = string.Empty;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                Article article = new Article(commands[0], commands[1], commands[2]);
                articles.Add(article);
            }

            string input = Console.ReadLine();

            foreach(Article article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
}
