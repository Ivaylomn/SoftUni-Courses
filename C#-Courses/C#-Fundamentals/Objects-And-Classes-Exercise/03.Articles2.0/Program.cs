using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
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
            int articleCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < articleCount; i++)
            {
                string[] currentActicle = Console.ReadLine().Split(", ");

                //Article arcticle = new Article();
                //arcticle.Title = currentActicle[0];
                //arcticle.Content = currentActicle[1];
                //arcticle.Author = currentActicle[2];

                articles.Add(new Article(currentActicle[0], currentActicle[1], currentActicle[2]));

            }

            string articleInfo = Console.ReadLine();

            if (articleInfo == "title")
            {
                foreach (var item in articles.OrderBy(t => t.Title))
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else if (articleInfo == "content")
            {
                foreach (var item in articles.OrderBy(c => c.Content))
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                foreach (var item in articles.OrderBy(a => a.Author))
                {
                    Console.WriteLine(item.ToString());
                }
            }


        }
    }
}
