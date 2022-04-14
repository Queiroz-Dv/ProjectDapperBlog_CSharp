using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.CategoryView
{
    public static class CreateCategoryView
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Nova Categoria");
            Console.WriteLine("-------------");

            Console.Write("Nome: ");
            var name = Console.ReadLine();
            if (name == null || name == "")
            {
                Console.WriteLine("Dados nulos ou vazios não são permitidos tente novamente");
            }

            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            if (slug == null || slug == "")
            {
                Console.WriteLine("Dados nulos ou vazios não são permitidos tente novamente");
            }

            Create(new Category
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryView.Load();

        }

        private static void Create(Category category)
        {
            try
            {
                var repo = new Repository<Category>(Database.Connection);
                repo.Create(category);
                Console.WriteLine($"- {category.Name} - como nova categoria cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar a categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}