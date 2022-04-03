using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace ProjectDapperBlog_CSharp.Models
{
    [Table("[Category]")]
    public class Category
    {
        public Category()
        {
            Posts = new List<Post>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        //Associa com Posts
        public List<Post> Posts { get; set; }
    }
}
