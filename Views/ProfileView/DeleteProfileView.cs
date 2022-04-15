using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.ProfileView
{
    public class DeleteProfileView
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Deletar Perfil");
            Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuProfileView.Load();
        }

        private static void Delete(int id)
        {
            try
            {

                var repo = new Repository<Role>(Database.Connection);
                repo.Delete(id);
                Console.WriteLine("Perfil deletado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao deletar perfil");
                Console.WriteLine(ex.Message);
            }
        }
    }
}