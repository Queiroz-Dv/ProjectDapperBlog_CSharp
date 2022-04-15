using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.CategoryView
{
    public static class SearchCategoryView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Procurar Categoria");
            Console.WriteLine("-------------");
            Console.Write("Digite o Id da categoria: ");
            var id = Console.ReadLine();
            if (id == null || id == "")
            {
                Console.WriteLine("Dados incorretos tente novamente");
                return;
            }

            try
            {
                SearchCategory(int.Parse(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Categoria não encontrada, tente novamente.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            MenuCategoryView.Load();
        }

        private static void SearchCategory(int id)
        {
            try
            {
                var repo = new Repository<Category>(Database.Connection);
                var category = repo.Get(id);
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine();
                Console.WriteLine($"Nome: {category.Name}");
                Console.WriteLine();
                Console.WriteLine($"Slug: {category.Slug}");
                Console.WriteLine();
                Console.WriteLine("-------------");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Categoria não encontrada, tente novamente.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }
    }
}