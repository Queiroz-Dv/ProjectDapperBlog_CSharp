using Dapper;
using Microsoft.Data.SqlClient;
using ProjectDapperBlog_CSharp.Models;

namespace ProjectDapperBlog_CSharp.Repositories
{
    public class PRepository : Repository<Post>
    {
        private readonly SqlConnection _connection;

        public PRepository(SqlConnection connection)
            : base(connection)
            => _connection = connection;

        public List<Post> GetWithTags()
        {
            var query = @"
                        SELECT
                            [Post].[Id],
                            [Post].[Title],
                            [Post].[Summary],
                            [Post].[Slug],
                            [Tag].[Id],
                            [Tag].[Name]
                        FROM
                            [Post]
                            LEFT JOIN [PostTag] ON [Post].[Id] = [PostTag].[PostId]
                            LEFT JOIN [Tag] ON [PostTag].[TagId] = [Tag].[Id]
                        GROUP BY 
                            [Post].[Id],
                            [Post].[Title],
                            [Post].[Summary],
                            [Post].[Slug],
                            [Tag].[Id],
                            [Tag].[Name],
                            [Tag].[Slug]";

            var items = _connection.Query(query,
                (Func<Post, Tag, Post>)((p, t) =>
                {
                    var post = new List<Post>().FirstOrDefault(x => x.Id == p.Id);
                    if (post == null)
                    {
                        post = p;
                        if (t != null)
                            post.Tags.Add(t);
                        new List<Post>().Add(post);
                    }
                    else
                    {
                        post.Tags.Add(t);
                    }
                    return p;
                }), splitOn: "Id");
            return new List<Post>();
        }
    }
}
