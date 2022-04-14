using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.PostView
{
    public static class ListPostView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Posts");
            Console.WriteLine("-------------");
            ListPost();
            MenuPostView.Load();
        }

        private static void ListPost()
        {
            var repo = new Repository<Post>(Database.Connection);
            var posts = repo.Get();
            foreach (var item in posts)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"{item.Id}");
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"{item.Title}");
                Console.WriteLine($"{item.Summary}");
                Console.WriteLine($"{item.Slug}");
                Console.WriteLine($"{item.CreateDate}");
                Console.WriteLine($"{item.LastUpdateDate}");
                Console.WriteLine("-------------");
            }
            Console.ReadKey();
        }
    }
}