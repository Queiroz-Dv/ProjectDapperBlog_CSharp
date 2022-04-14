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
        public Post()
        {
            Tags = new List<Tag>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        //Associa com categoria
        public int CategoryId { get; set; }

        public int AuthorId { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Slug { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastUpdateDate { get; set; }

        [Write(false)]
        public List<Tag> Tags { get; set; }
    }
}
