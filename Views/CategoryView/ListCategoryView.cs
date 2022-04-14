using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.CategoryView
{
    public static class ListCategoryView
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Lista de Categoria");
            Console.WriteLine("------------------");
            List();
            Console.ReadKey();
            MenuCategoryView.Load();
        }
        public static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var lists = repository.Get();

            foreach (var item in lists)
            {

                Console.WriteLine($"{item.Id} - {item.Name} , {item.Slug} ");
            }

        }
    }
}