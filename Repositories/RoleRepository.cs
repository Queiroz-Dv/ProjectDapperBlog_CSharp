using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using ProjectDapperBlog_CSharp.Models;

namespace ProjectDapperBlog_CSharp.Repositories
{
    // Exemplo de repositório único
    // Este exemplo não deve ser seguido
    public class RoleRepository
    {
        private readonly SqlConnection _connection;

        public RoleRepository(SqlConnection connection) => _connection = connection;

        public IEnumerable<Role> GetAll() => _connection.GetAll<Role>();

        public Role Get(int id) => _connection.Get<Role>(id);

        public void Create(Role role) => _connection.Insert(role);


        public void Update(Role role)
        {
            if (role.Id != 0)
                _connection.Update(role);
        }

        public void Delete(Role role)
        {
            if (role.Id != 0)
                _connection.Delete(role);
        }

        public void Delete(int id)
        {
            if (id != 0)
                return;
            else
                _connection.Delete(_connection.Get<Role>(id));
        }
    }
}
