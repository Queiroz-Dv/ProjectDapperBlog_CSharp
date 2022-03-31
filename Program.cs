using Microsoft.Data.SqlClient;
using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;

namespace ProjectDapperBlog
{
    class Program
    {
        private const string CONNECTION_STRING = @"Server=DESKTOP-6OMQR12\SQLEXPRESS;Database=Blog;Integrated Security=True;TrustServerCertificate=True;";

        static void Main(string[] args)
        {
            var connection = new SqlConnection(CONNECTION_STRING);
            connection.Open();
            ReadUsers(connection);
            // ReadRoles(connection);
            // ReadTags(connection);
            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repo = new Repository<User>(connection);
            var items = repo.Get();

            foreach (var item in items)
            {
                Console.WriteLine(item.Name);
                foreach (var role in item.Roles)
                {
                    Console.WriteLine($" - {role.Name}");
                }
            }
        }

        public static void CreateUsers(SqlConnection connection)
        {
            var user = new User()
            {
                Bio = "Equipe Queiroz",
                Email = "eduardo@queiroz.io",
                Image = "https://...",
                Name = "Equipe Queiroz",
                PasswordHash = "Hashing",
                Slug = "equipe-queiroz-asp"
            };
            var repo = new Repository<User>(connection);
            repo.Create(user);

        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repo = new Repository<Role>(connection);
            var items = repo.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }

        public static void ReadTags(SqlConnection connection)
        {
            var repo = new Repository<Tag>(connection);
            var items = repo.Get();

            foreach (var item in items)
                Console.WriteLine(item.Name);
        }
    }
}

