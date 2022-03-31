using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.TagView
{
    public class UpdateTagView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atulizar Tag");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuTagView.Load();
        }

        private static void Update(Tag tag)
        {
            try
            {
                var repo = new Repository<Tag>(Database.Connection);
                repo.Update(tag);
                Console.WriteLine($"- {tag.Name} - atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}