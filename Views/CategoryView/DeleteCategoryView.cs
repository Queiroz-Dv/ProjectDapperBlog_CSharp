using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.CategoryView
{
    public static class DeleteCategoryView
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Deletar Categoria");
            Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuCategoryView.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                var repo = new Repository<Category>(Database.Connection);
                repo.Delete(id);
                Console.WriteLine("Categoria deletada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao deletar categoria");
                Console.WriteLine(ex.Message);
            }
        }
    }
}