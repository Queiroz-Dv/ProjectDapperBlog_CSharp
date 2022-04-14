using System;

namespace ProjectDapperBlog.Views.UserView
{
    public class MenuUserView
    {
        public static void Load()
        {
            const short USER_LIST = 1;
            const short USER_SEACHER = 2;
            const short USER_CREATE = 3;
            const short USER_UPDATE = 4;
            const short USER_DELETE = 5;
            const short SAIR = 0;

            Console.Clear();
            Console.WriteLine("Gestor de Usuários");
            Console.WriteLine("---------------");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Usuários");
            Console.WriteLine("2 - Procurar Usuário");
            Console.WriteLine("3 - Cadastrar Usuário");
            Console.WriteLine("4 - Atualizar Usuário");
            Console.WriteLine("5 - Deletar Usuário");
            Console.WriteLine("0 - Voltar");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case USER_LIST:
                    ListUserView.Load();
                    break;
                case USER_SEACHER:
                    SearchUserView.Load();
                    break;
                case USER_CREATE:
                    CreateUserView.Load();
                    break;
                case USER_UPDATE:
                    UpdateUserView.Load();
                    break;
                case USER_DELETE:
                    DeleteUserView.Load();
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