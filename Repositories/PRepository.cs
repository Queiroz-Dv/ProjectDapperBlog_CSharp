using Dapper;
using Microsoft.Data.SqlClient;
using ProjectDapperBlog_CSharp.Models;
using System.Collections.Generic;
using System.Linq;

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

            var posts = new List<Post>();
            var items = _connection.Query<Post, Tag, Post>(query,
                (post, tag) =>
                {
                    var pst = posts.FirstOrDefault(x => x.Id == post.Id);
                    if (pst == null)
                    {
                        pst = post;
                        if (tag != null)
                        {
                            pst.Tags.Add(tag);
                        }
                        posts.Add(pst);
                    }
                    else
                    {                        
                        pst.Tags.Add(tag);
                    }
                    return post;
                }, splitOn: "Id");
            return posts;
        }
    }
}
