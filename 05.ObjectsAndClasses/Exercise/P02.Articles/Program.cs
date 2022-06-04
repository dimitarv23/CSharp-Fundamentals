using System;

namespace P02.Articles
{
    class Article
    {
        public Article(string ttl, string ctn, string ath)
        {
            this.Title = ttl;
            this.Content = ctn;
            this.Author = ath;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Edit")
                {
                    article.Edit(commands[1]);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commands[1]);
                }
                else if (commands[0] == "Rename")
                {
                    article.Rename(commands[1]);
                }
            }

            Console.WriteLine(article);
        }
    }
}
