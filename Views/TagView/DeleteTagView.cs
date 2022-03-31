using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog_CSharp.Views.TagView
{
    public static class DeleteTagView
    {
        public static void Load()
        {

            Console.Clear();
            Console.WriteLine("Deletar uma Tag");
            Console.WriteLine("-------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Delete(int.Parse(id));
            Console.ReadKey();
            MenuTagView.Load();
        }

        private static void Delete(int id)
        {
            try
            {
                
                var repo = new Repository<Tag>(Database.Connection);
                repo.Delete(id);
                Console.WriteLine("Tag deletada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao deletar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}