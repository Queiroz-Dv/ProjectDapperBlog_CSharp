using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDapperBlog_CSharp.Models
{
    [Table("[Post]")]
    public class Post
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }
    }
}
