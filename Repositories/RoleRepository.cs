using Dapper.Contrib.Extensions;
using ProjectDapperBlog_CSharp.Models;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace ProjectDapperBlog_CSharp.Repositories
{
    public class RoleRepository
    {
        private readonly SqlConnection _connection;

        public RoleRepository(SqlConnection connection)
            => _connection = connection;

        public IEnumerable<Role> GetAll()
            => _connection.GetAll<Role>();

        public Role Get(int id)
            => _connection.Get<Role>(id);

        public void Create(Role role)
            => _connection.Insert(role);


        public void Update(Role role)
        {
            if (role.Id != 0)
            {
                _connection.Update(role);
            }
        }

        public void Delete(Role role)
        {
            if (role.Id != 0)
            {
                _connection.Delete(role);
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
                var role = _connection.Get<Role>(id);
                _connection.Delete(role);
            }
        }
    }
}
