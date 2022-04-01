using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp;
using ProjectDapperBlog_CSharp.Repositories;
using ProjectDapperBlog_CSharp.Views.TagView;
using System;

namespace ProjectDapperBlog.Views.UserView
{
    public class SearchUserView
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Procurar Usuários");
            Console.WriteLine("-------------");
            Console.Write("Digite o Id do usuário: ");
            var id = Console.ReadLine();

            try
            {
                SearchUser(int.Parse(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Usuário não encontrado, tente novamente.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            MenuTagView.Load();
        }

        private static void SearchUser(int id)
        {
            try
            {
                var repo = new Repository<User>(Database.Connection);
                var user = repo.Get(id);
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine();
                Console.WriteLine($"{user.Name}");
                Console.WriteLine();
                Console.WriteLine($"{user.Email}");
                Console.WriteLine();
                Console.WriteLine($"{user.Bio}");
                Console.WriteLine();
                Console.WriteLine($"{user.Image}");
                Console.WriteLine();
                Console.WriteLine($"{user.Slug}");
                Console.WriteLine();
                Console.WriteLine("-------------");
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Usuário não encontrado, tente novamente.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }

    }
}