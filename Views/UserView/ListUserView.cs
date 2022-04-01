using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp;
using ProjectDapperBlog_CSharp.Repositories;
using ProjectDapperBlog_CSharp.Views.TagView;
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
            MenuTagView.Load();
        }

        private static void ListUser()
        {
            var repo = new Repository<User>(Database.Connection);
            var users = repo.Get();

            foreach (var item in users)
            {
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine($"{item.Id}");
                Console.WriteLine($"{item.Name}");
                Console.WriteLine($"{item.Email}");
                Console.WriteLine($"{item.Bio}");
                Console.WriteLine($"{item.Image}");
                Console.WriteLine($"{item.Slug}");
                Console.WriteLine("-------------");
            }

            Console.ReadKey();
        }

    }
}