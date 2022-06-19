using System;
using System.Collections.Generic;

namespace P05.HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string articleTitle = Console.ReadLine();
            string articleContent = Console.ReadLine();
            List<string> comments = new List<string>();

            string comment = Console.ReadLine();

            while (comment != "end of comments")
            {
                comments.Add(comment);
                comment = Console.ReadLine();
            }

            Console.WriteLine($"<h1> {Environment.NewLine}    {articleTitle} {Environment.NewLine}</h1> ");
            Console.WriteLine($"<article> {Environment.NewLine}    {articleContent} {Environment.NewLine}</article> ");

            foreach (var c in comments)
            {
                Console.WriteLine($"<div> {Environment.NewLine}    {c} {Environment.NewLine}</div> ");
            }
        }
    }
}
