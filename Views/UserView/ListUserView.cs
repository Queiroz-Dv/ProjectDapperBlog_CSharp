using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog.Views.UserView
{
    public class ListUserView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de Usuários");
            Console.WriteLine("-------------");
            ListUser();
            MenuUserView.Load();
        }

        private static void ListUser()
        {
            var repo = new URepository(Database.Connection);
            var users = repo.GetWithRoles();
            foreach (var item in users)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"Detalhes do usuário {item.Name}");
                Console.WriteLine($"Id: {item.Id}");
                Console.WriteLine($"Nome: {item.Name}");
                Console.WriteLine($"E-mail: {item.Email}");
                Console.WriteLine($"Bio: {item.Bio}");
                Console.WriteLine($"Imagem: {item.Image}");
                Console.WriteLine($"Slug: {item.Slug}");
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($"{role.Name}");
                    Console.WriteLine($"{role.Slug}");
                }
                Console.WriteLine("-------------");
            }

            Console.ReadKey();
        }

    }
}