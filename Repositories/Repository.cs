using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace ProjectDapperBlog_CSharp.Repositories
{
    // Classe Genérica
    // Só vai aceitar a criação de repositórios de algum tipo
    // onde o tipo seja uma classe
    public class Repository<T> where T : class
    {
        private readonly SqlConnection _connection;

        public Repository(SqlConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<T> Get()
            => _connection.GetAll<T>();

        public T Get(int id)
            => _connection.Get<T>(id);

        public void Create(T model)
            => _connection.Insert(model);

        public void Update(T model)
            => _connection.Update(model);

        public void Delete(T model)
            => _connection.Delete(model);

        public void Delete(int id)
        {
            var model = _connection.Get<T>(id);
            _connection.Delete(model);
        }
    }
}
