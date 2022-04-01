using ProjectDapperBlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDapperBlog_CSharp.Views.CategoryView
{
    public static class MenuCategoryView
    {
        public static void Load()
        {
            const short CATEGORY_LIST = 1;
            const short CATEGORY_SEACHER = 2;
            const short CATEGORY_CREATE = 3;
            const short CATEGORY_UPDATE = 4;
            const short CATEGORY_DELETE = 5;
            const short SAIR = 0;

            Console.Clear();
            Console.WriteLine("Gestor de Categorias");
            Console.WriteLine("---------------");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Categorias");
            Console.WriteLine("2 - Procurar Categoria");
            Console.WriteLine("3 - Cadastrar Categoria");
            Console.WriteLine("4 - Atualizar Categoria");
            Console.WriteLine("5 - Deletar Categoria");
            Console.WriteLine("0 - Voltar");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case CATEGORY_LIST:
                    ListCategoryView.Load();
                    break;
                case CATEGORY_SEACHER:
                    SearchCategoryView.Load();
                    break;
                case CATEGORY_CREATE:
                    CreateCategoryView.Load();
                    break;
                case CATEGORY_UPDATE:
                    UpdateCategoryView.Load();
                    break;
                case CATEGORY_DELETE:
                    DeleteCategoryView.Load();
                    break;
                case SAIR:
                    Program.Load();
                    break;
                default:
                    break;
            }
        }
    }
}
