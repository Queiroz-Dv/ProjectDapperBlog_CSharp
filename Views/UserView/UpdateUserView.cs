using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog.Views.UserView
{
    public static class UpdateUserView
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atulizar Usuário");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();
            if (id == null || id == "")
            {
                Console.WriteLine("Dados nulos ou vazios não podem ser salvos!");
                return;
            }
            Console.Write("Nome: ");
            var name = Console.ReadLine();
            if (name == null || name == "")
            {
                Console.WriteLine("Dados nulos ou vazios não podem ser salvos!");
                return;
            }

            Console.Write("Email: ");
            var email = Console.ReadLine();
            if (email == null || email == "")
            {
                Console.WriteLine("Dados nulos ou vazios não podem ser salvos!");
                return;
            }

            Console.Write("Senha: ");
            var password = Console.ReadLine();
            if (password == null || password == "")
            {
                Console.WriteLine("Dados nulos ou vazios não podem ser salvos!");
                return;
            }

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Imagem: ");
            var image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            if (slug == null || slug == "")
            {
                Console.WriteLine("Dados nulos ou vazios não podem ser salvos!");
                return;
            }

            Console.WriteLine("Aperte qualquer tecla para prosseguir com a atualização");
            Console.ReadKey();

            Update(new User
            {
                Id = int.Parse(id),
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = image,
                Slug = slug
            });
            Console.ReadKey();
            MenuUserView.Load();
        }

        private static void Update(User user)
        {
            try
            {
                var repo = new Repository<User>(Database.Connection);
                repo.Update(user);
                Console.WriteLine($"- {user.Name} - atualizado(a) com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao atualizar o usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}