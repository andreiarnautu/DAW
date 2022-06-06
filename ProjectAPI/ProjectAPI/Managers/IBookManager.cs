using ProjectAPI.Entities;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Managers
{
    public interface IBookManager
    {
        public void Create(BookModel model);
        public void Update(BookModel model);

        public List<Book> GetBooks();

        public Book GetBookById(int id);
        public void Delete(int id);
    }
}
