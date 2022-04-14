using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.ProfileView
{
    public static class CreateProfileView
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Novo Perfil");
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

            Create(new Role
            {
                Name = name,
                Slug = slug
            });
            Console.ReadKey();
            MenuProfileView.Load();

        }

        private static void Create(Role role)
        {
            try
            {
                var repo = new Repository<Role>(Database.Connection);
                repo.Create(role);
                Console.WriteLine($"- {role.Name} - como novo perfil cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar a perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}