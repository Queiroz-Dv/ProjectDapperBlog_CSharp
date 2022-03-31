using System;

namespace ProjectDapperBlog_CSharp.Views.TagView
{
    public static class MenuTagView
    {
        public static void Load()
        {
            const short TAG_LIST = 1;
            const short TAG_CREATE = 2;
            const short TAG_UPDATE = 3;
            const short TAG_DELETE = 4;
            Console.Clear();
            Console.WriteLine("Gestor de Tags");
            Console.WriteLine("---------------");
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Tags");
            Console.WriteLine("2 - Cadastrar tags");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case TAG_LIST:
                    ListTagView.Load();
                    break;
                case TAG_CREATE:
                    CreateTagView.Load();
                    break;
                case TAG_UPDATE:
                    UpdateTagView.Load();
                    break;
                case TAG_DELETE:
                    DeleteTagView.Load();
                    break;
                default:
                    break;
            }
        }
    }
}
