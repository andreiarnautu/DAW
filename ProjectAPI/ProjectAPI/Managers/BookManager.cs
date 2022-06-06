using ProjectAPI.Entities;
using ProjectAPI.Models;
using ProjectAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Managers
{
    public class BookManager : IBookManager
    {
        private readonly IBookRepository bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public void Create(BookModel model)
        {

            var newBook = new Book
            {
                BookID = model.BookID,
                BookName = model.BookName,
                AuthorID = model.AuthorID
            };

            bookRepository.Create(newBook);
        }

        public void Update(BookModel model)
        {
            var newBook = GetBookById(model.BookID);
            newBook.BookID = model.BookID;
            newBook.AuthorID = model.AuthorID;
            newBook.BookName = model.BookName;

            bookRepository.Update(newBook);
        }

        public List<Book> GetBooks()
        {
            return bookRepository.GetBooks().ToList();
        }

        public Book GetBookById(int id)
        {
            var book = bookRepository
                .GetBooks()
                .Where(book => book.BookID == id)
                .FirstOrDefault();
            return book;
        }

        public void Delete(int id)
        {
            var book = GetBookById(id);
            bookRepository.Delete(book);
        }
    }
}
