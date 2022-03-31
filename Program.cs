using Dapper.Contrib.Extensions;
using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp.Repositories;
using System;
using Microsoft.Data.SqlClient;

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
            ReadRoles(connection);
            connection.Close();
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var repo = new UserRepository(connection);
            var users = repo.GetAll();

            foreach (var user in users)
                Console.WriteLine(user.Name);
        }

        public static void ReadRoles(SqlConnection connection)
        {
            var repo = new RoleRepository(connection);
            var roles = repo.GetAll();

            foreach (var role in roles)
                Console.WriteLine(role.Name);
        }

    }
}

