using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using ProjectDapperBlog.Models;
using System;

namespace ProjectDapperBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            const string CONNECTION_STRING = @"Server=DESKTOP-6OMQR12\SQLEXPRESS;Database=Blog;Integrated Security=True;TrustServerCertificate=True;";
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                ReadUsers(connection);
            }
        }

        public static void ReadUsers(SqlConnection connection)
        {
            var users = connection.GetAll<User>();
            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
            Console.ReadKey();
        }
    }
}
