using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.TagView
{
    public static class ListTagView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Tags");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
        }

        private static void List()
        {
            var repo = new Repository<Tag>(Database.Connection);
            var tags = repo.Get();

            foreach (var item in tags)
            {
                Console.WriteLine($"{item.Id} - {item.Name} - ({item.Slug})");
            }
        }
    }
}