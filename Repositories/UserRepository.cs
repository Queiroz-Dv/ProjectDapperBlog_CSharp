using Dapper.Contrib.Extensions;
using ProjectDapperBlog.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

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
            user.Id = 0;
            _connection.Insert(user);
        }

        public void Update(User user)
        {
            if (user.Id != 0)
            {
                _connection.Update<User>(user);
            }
        }

        public void Delete(User user)
        {
            if (user.Id != 0)
            {
                _connection.Delete<User>(user);
            }
        }

        public void Delete(int id)
        {
            if (id != 0)
            {
                return;
            }
            else
            {
                var user = _connection.Get<User>(id);
                _connection.Delete<User>(user);
            }
        }
    }
}
