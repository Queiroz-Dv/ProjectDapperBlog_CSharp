using ProjectDapperBlog;
using System;

namespace ProjectDapperBlog_CSharp.Views.ProfileView
{
    class MenuProfileView
    {
        public static void Load()
        {
            const short PROFILE_LIST = 1;
            const short PROFILE_SEACHER = 2;
            const short PROFILE_CREATE = 3;
            const short PROFILE_UPDATE = 4;
            const short PROFILE_DELETE = 5;
            const short SAIR = 0;

            Console.Clear();
            Console.WriteLine("Gestor de Perfis");
            Console.WriteLine("---------------");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Perfis");
            Console.WriteLine("2 - Procurar Perfil");
            Console.WriteLine("3 - Cadastrar Perfil");
            Console.WriteLine("4 - Atualizar Perfil");
            Console.WriteLine("5 - Deletar Perfil");
            Console.WriteLine("0 - Voltar");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case PROFILE_LIST:
                    ListProfileView.Load();
                    break;
                case PROFILE_SEACHER:
                    SearchProfileView.Load();
                    break;
                case PROFILE_CREATE:
                    CreateProfileView.Load();
                    break;
                case PROFILE_UPDATE:
                    UpdateProfileView.Load();
                    break;
                case PROFILE_DELETE:
                    DeleteProfileView.Load();
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
