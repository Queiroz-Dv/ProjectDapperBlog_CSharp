using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.ProfileView
{
    public static class SearchProfileView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Procurar Perfil");
            Console.WriteLine("-------------");
            Console.Write("Digite o Id do perfil: ");
            var id = Console.ReadLine();
            if (id == null || id == "")
            {
                Console.WriteLine("Dados incorretos tente novamente");
                return;
            }

            try
            {
                SearchProfile(int.Parse(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Usuário não encontrado, tente novamente.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            MenuProfileView.Load();
        }

        private static void SearchProfile(int id)
        {
            try
            {
                var repo = new Repository<Role>(Database.Connection);
                var role = repo.Get(id);
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine($"Dados do perfil: {role.Name}");
                Console.WriteLine($"{role.Id}");
                Console.WriteLine();
                Console.WriteLine($"{role.Slug}");
                Console.WriteLine();
                Console.WriteLine("-------------");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Perfil não encontrado, tente novamente.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }
    }
}