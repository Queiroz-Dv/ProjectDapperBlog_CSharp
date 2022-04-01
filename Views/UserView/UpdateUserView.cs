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
            //Criar validações
            Console.Clear();
            Console.WriteLine("Atulizar Usuário");
            Console.WriteLine("-------------");
            Console.Write("Id: ");
            var id = Console.ReadLine();
            Console.Write("Nome: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Senha: ");
            var password = Console.ReadLine();

            Console.Write("Bio: ");
            var bio = Console.ReadLine();

            Console.Write("Imagem: ");
            var image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

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
            MenuUsuarioView.Load();
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