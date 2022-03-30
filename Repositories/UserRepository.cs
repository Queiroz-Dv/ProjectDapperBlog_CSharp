using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using ProjectDapperBlog.Models;
using System.Collections.Generic;

namespace ProjectDapperBlog_CSharp.Repositories
{
    public class UserRepository
    {
        private readonly SqlConnection _connection;

        public UserRepository(SqlConnection connection)
        {
              _connection = connection;
        }
        
        public IEnumerable<User> GetAll()
        {
            return _connection.GetAll<User>();
        }

        public User Get(int id)
        {
            return _connection.Get<User>(id);
        }

        public void Create(User user)
        {
            _connection.Insert(user);
        }
    }
}
