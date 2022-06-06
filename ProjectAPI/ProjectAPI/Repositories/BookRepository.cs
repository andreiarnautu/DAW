using ProjectAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly ProjectContext db;

        public BookRepository(ProjectContext db)
        {
            this.db = db;
        }

        public void Create(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
        }

        public IQueryable<Book> GetBooks()
        {
            var books = db.Books;
            return books;
        }

        public void Update(Book book)
        {
            db.Books.Update(book);
            db.SaveChanges();
        }

        public void Delete(Book book)
        {
            db.Books.Remove(book);
            db.SaveChanges();
        }
    }
}
