using Microsoft.Data.SqlClient;
using ProjectDapperBlog.Views.UserView;
using ProjectDapperBlog_CSharp;
using ProjectDapperBlog_CSharp.Views.CategoryView;
using ProjectDapperBlog_CSharp.Views.PostView;
using ProjectDapperBlog_CSharp.Views.ProfileView;
using ProjectDapperBlog_CSharp.Views.TagView;
using System;

namespace ProjectDapperBlog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=DESKTOP-6OMQR12\SQLEXPRESS;Database=Blog;Integrated Security=True;TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);

            Database.Connection.Open();

            Load();

            Console.ReadKey();

            Database.Connection.Close();
        }

        public static void Load()
        {

            const short GESTOR_USUARIO = 1;
            const short GESTOR_PERFIL = 2;
            const short GESTOR_CATEGORIA = 3;
            const short GESTOR_POST = 4;
            const short GESTOR_TAG = 5;
            const short VINCULAR_PERFIL = 6;
            const short VINCULAR_POST = 7;
            const short RELATORIOS = 8;
            const short SAIR = 0;

            Console.Clear();
            Console.WriteLine("Dapper Manager Blog");
            Console.WriteLine("---------------");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - Gestor de Usuários");
            Console.WriteLine("2 - Gestor de Perfil");
            Console.WriteLine("3 - Gestor de Categoria");
            Console.WriteLine("4 - Gestor de Post");
            Console.WriteLine("5 - Gestor de Tag");
            Console.WriteLine("6 - Vincular Perfil/Usuário");
            Console.WriteLine("7 - Vincular Post/Tag");
            Console.WriteLine("8 - Relatórios");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case GESTOR_USUARIO:
                    MenuUserView.Load();
                    break;
                case GESTOR_PERFIL:
                    MenuProfileView.Load();
                    break;
                case GESTOR_CATEGORIA:
                    MenuCategoryView.Load();
                    break;
                case GESTOR_POST:
                    MenuPostView.Load();
                    break;
                case GESTOR_TAG:
                    MenuTagView.Load();
                    break;
                case SAIR:
                    Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }

    }
}

