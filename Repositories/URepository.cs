using Dapper;
using Microsoft.Data.SqlClient;
using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp.Models;

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
            var query = @"
                SELECT
	                [User].*,
	                [Role].*
                FROM
	                [User]
	                LEFT JOIN [UserRole] ON [UserRole].[UserId] = [User].[Id]
	                LEFT JOIN [Role] ON [UserRole].[RoleId] = [Role].[Id]";

            var items = _connection.Query(query,
                (Func<User, Role, User>)((u, r) =>
                {
                    var user = new List<User>().FirstOrDefault(x => x.Id == u.Id);
                    if (user == null)
                    {
                        user = u;
                        if (r != null)
                            user.Roles.Add(r);
                        new List<User>().Add(user);
                    }
                    else
                    {
                        user.Roles.Add(r);
                    }
                    return u;
                }), splitOn: "Id");
            return new List<User>();
        }
    }
}
