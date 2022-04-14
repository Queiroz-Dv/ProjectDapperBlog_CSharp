using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog.Views.UserView
{
    public static class CreateUserView
    {
        public static void Load()
        {
            // Preparar validações depois
            Console.Clear();
            Console.WriteLine("Criar Usuário");
            Console.WriteLine("-------------");
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

            Console.WriteLine("Aperte qualquer tecla para prosseguir com o cadastro");
            Console.ReadKey();
            
            Create(new User
            {
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

        private static void Create(User user)
        {
            try
            {
                // Está salvando dados vazios no banco de dados
                var repo = new Repository<User>(Database.Connection);
                repo.Create(user);
                Console.WriteLine($"- {user.Name} - salvo(a) com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar usuário");
                Console.WriteLine(ex.Message);
            }
        }
    }
}