using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace ProjectDapperBlog_CSharp.Repositories
{
    public class Repository
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
        {
            _connection = connection;
        }

    }
}
