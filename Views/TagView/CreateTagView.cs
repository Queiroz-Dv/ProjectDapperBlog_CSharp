using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.TagView
{
    public static class CreateTagView
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Nova Tag");
            Console.WriteLine("-------------");
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            // Quando chamar o Create faz a instância
            //  adicinando os valores diretamente
            Create(new Tag
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagView.Load();

        }

        private static void Create(Tag tag)
        {
            try
            {
                // Instância do repositório
                var repo = new Repository<Tag>(Database.Connection);
                repo.Create(tag);
                Console.WriteLine($"- {tag.Name} - cadastrada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}