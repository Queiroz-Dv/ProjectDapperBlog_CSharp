using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.ProfileView
{
    public static class ListProfileView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Perfis");
            Console.WriteLine("-------------");
            ListProfile();
            MenuProfileView.Load();
        }

        private static void ListProfile()
        {
            var repo = new Repository<Role>(Database.Connection);
            var roles = repo.Get();
            foreach (var item in roles)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"Perfil: {item.Name}");
                Console.WriteLine($"Slug: {item.Slug}");
                Console.WriteLine("-------------");
            }

            Console.ReadKey();
        }
    }
}