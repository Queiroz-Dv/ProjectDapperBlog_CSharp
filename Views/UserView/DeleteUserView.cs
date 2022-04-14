using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog.Views.UserView
{
    public static class DeleteUserView
    {
        public static void Load()
        {
            // Criar validações
            Console.Clear();
            Console.WriteLine("Deletar um usuário");
            Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuUserView.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repo = new Repository<User>(Database.Connection);
                repo.Delete(id);
                Console.WriteLine("Usuário removido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao deletar o usuário, tente novamente");
                Console.WriteLine(ex.Message);
            }
        }
    }
}