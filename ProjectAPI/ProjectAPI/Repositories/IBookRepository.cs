using ProjectAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public interface IBookRepository
    {
        public void Create(Book book);
        public IQueryable<Book> GetBooks();

        public void Update(Book book);
        public void Delete(Book book);
    }
}
