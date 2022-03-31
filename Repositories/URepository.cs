using Dapper;
using Microsoft.Data.SqlClient;
using ProjectDapperBlog.Models;
using ProjectDapperBlog_CSharp.Models;
using System.Collections.Generic;
using System.Linq;

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

            var users = new List<User>();
            var items = _connection.Query<User, Role, User>(query,
                (user, role) =>
                {
                    var usr = users.FirstOrDefault(x => x.Id == user.Id);
                    if (usr == null) // Se não existe na lista 
                    {
                        usr = user;
                        if (role != null)
                        {
                            usr.Roles.Add(role);
                        }
                        usr.Roles.Add(role);
                        users.Add(usr);
                    }
                    else
                    {
                        usr.Roles.Add(role);
                    }
                    return user;
                }, splitOn: "[Id]");
            return users;
        }
    }
}
