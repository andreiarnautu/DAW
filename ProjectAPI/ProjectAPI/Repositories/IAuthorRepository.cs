using ProjectAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public interface IAuthorRepository
    {
        public void Create(Author author);
        public IQueryable<Author> GetAuthors();
        public void Update(Author author);
        public void Delete(Author author);
    }
}
