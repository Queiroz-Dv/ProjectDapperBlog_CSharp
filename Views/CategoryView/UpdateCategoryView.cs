using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.CategoryView
{
    public static class UpdateCategoryView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atulizar Categoria");
            Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();
            if (id == null || id == "")
            {
                Console.WriteLine("Dados nulos ou vazios não podems ser salvos. Tente novamente");
                return;
            }
            Console.Write("Nome: ");
            var name = Console.ReadLine();
            if (name == null || name == "")
            {
                Console.WriteLine("Dados nulos ou vazios não podems ser salvos. Tente novamente");
                return;
            }

            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            if (slug == null || slug == "")
            {
                Console.WriteLine("Dados nulos ou vazios não podems ser salvos. Tente novamente");
                return;
            }
            Update(new Category
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuCategoryView.Load();
        }

        private static void Update(Category category)
        {
            try
            {
                var repo = new Repository<Category>(Database.Connection);
                repo.Update(category);
                Console.WriteLine($"- {category.Name} - atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}