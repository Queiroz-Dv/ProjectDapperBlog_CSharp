using Microsoft.Data.SqlClient;
using ProjectDapperBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDapperBlog_CSharp.Repositories
{
    public class URepository : Repository<User>
    {
        private readonly SqlConnection _connection;

        public URepository(SqlConnection connection)
            : base(connection)
            => _connection = connection;

        public List<User> GetWithRoles()
        {

        }
    }
}
