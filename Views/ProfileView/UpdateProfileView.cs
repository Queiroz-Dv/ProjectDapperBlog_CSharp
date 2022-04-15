using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.ProfileView
{
    public static class UpdateProfileView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atulizar Perfil");
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
            Update(new Role
            {
                Id = int.Parse(id),
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuProfileView.Load();
        }

        private static void Update(Role tag)
        {
            try
            {
                var repo = new Repository<Role>(Database.Connection);
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