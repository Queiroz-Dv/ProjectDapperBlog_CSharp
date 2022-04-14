using Dapper.Contrib.Extensions;
using ProjectDapperBlog_CSharp.Models;
using System.Collections.Generic;

namespace ProjectDapperBlog.Models
{
    [Table("[User]")] //Para não pluralizar a tabela
    public class User
    {
        public User()
            => Roles = new List<Role>();

        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public string Bio { get; set; }

        public string Image { get; set; }

        public string Slug { get; set; }

        [Write(false)] // Para não incluir os perfis na hora de salvar
        public List<Role> Roles { get; set; }
    }
}