using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using ProjectDapperBlog.Models;
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
            // ReadUsers(connection);
            // ReadUser(connection);
            // CreateUser(connection);
            // UpdateUser(connection);
            // DeleteUser(connection);
            connection.Close();
        }

        public static void ReadUser(SqlConnection connection)
        {
            var repo = new UserRepository(connection);
            var users = repo.GetAll();

            foreach (var user in users)
                Console.WriteLine(user.Name);

        }

        public static void CreateUser(SqlConnection connection)
        {
            var user = new User()
            {
                Bio = "Equipe Dapper",
                Email = "dapper@sharp.io",
                Image = "https://...",
                Name = "Equipe Dapper Sharp",
                PasswordHash = "Hashing",
                Slug = "equipe-dapper-sharp"
            };

            connection.Insert<User>(user);
            Console.WriteLine("Cadastro realizado");
            Console.ReadKey();
        }

        public static void UpdateUser(SqlConnection connection)
        {
            var user = new User()
            {
                Id = 2,
                Bio = "Equipe | Dapper",
                Email = "dapper@sharp.com",
                Image = "http://...",
                Name = "Equipe Sharp",
                PasswordHash = "Hashing",
                Slug = "equipe-sharp"
            };

            connection.Update<User>(user);
            Console.WriteLine("Atulização bem sucedida");
            Console.ReadKey();
        }

        public static void DeleteUser(SqlConnection connection)
        {
            var user = connection.Get<User>(2);
            connection.Delete<User>(user);
            Console.WriteLine("Remoção bem sucedida");
            Console.ReadKey();
        }
    }
}

