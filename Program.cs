using Microsoft.Data.SqlClient;
using ProjectDapperBlog_CSharp;
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

        private static void Load()
        {

            const short GESTOR_USUARIO = 1;
            const short GESTOR_PERFIL = 2;
            const short GESTOR_CATEGORIA = 3;
            const short GESTOR_TAG = 4;
            const short VINCULAR_PERFIL = 5;
            const short VINCULAR_POST = 6;
            const short RELATORIOS = 7;

            Console.Clear();
            Console.WriteLine("Dapper Blog");
            Console.WriteLine("---------------");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - Gestor de Usuários");
            Console.WriteLine("2 - Gestor de Perfil");
            Console.WriteLine("3 - Gestor de Categoria");
            Console.WriteLine("4 - Gestor de Tag");
            Console.WriteLine("5 - Vincular Perfil/Usuário");
            Console.WriteLine("6 - Vincular Post/Tag");
            Console.WriteLine("7 - Relatórios");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case GESTOR_TAG:
                    MenuTagView.Load();
                    break;
                default:
                    break;
            }
        }

    }
}

