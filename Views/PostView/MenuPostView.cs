using ProjectDapperBlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDapperBlog_CSharp.Views.PostView
{
    public class MenuPostView
    {
        public static void Load()
        {
            const short POST_LIST = 1;
            const short POST_SEACHER = 2;
            const short POST_CREATE = 3;
            const short POST_UPDATE = 4;
            const short POST_DELETE = 5;
            const short SAIR = 0;

            Console.Clear();
            Console.WriteLine("Gestor de Posts");
            Console.WriteLine("---------------");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Posts");
            Console.WriteLine("2 - Procurar Post");
            Console.WriteLine("3 - Cadastrar Post");
            Console.WriteLine("4 - Atualizar Post");
            Console.WriteLine("5 - Deletar Post");
            Console.WriteLine("0 - Voltar");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case POST_LIST:
                    ListPostView.Load();
                    break;
                case POST_SEACHER:
                    SearchPostView.Load();
                    break;
                case POST_CREATE:
                    CreatePostView.Load();
                    break;
                case POST_UPDATE:
                    UpdatePostView.Load();
                    break;
                case POST_DELETE:
                    DeletePostView.Load();
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
