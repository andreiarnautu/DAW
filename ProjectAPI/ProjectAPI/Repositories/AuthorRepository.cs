using ProjectAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ProjectContext db;

        public AuthorRepository(ProjectContext db)
        {
            this.db = db;
        }

        public void Create(Author author)
        {
            db.Authors.Add(author);
            db.SaveChanges();
        }

        public IQueryable<Author> GetAuthors()
        {
            var authors = db.Authors;
            return authors;
        }

        public void Update(Author author)
        {
            db.Authors.Update(author);
            db.SaveChanges();
        }

        public void Delete(Author author)
        {
            db.Authors.Remove(author);
            db.SaveChanges();
        }
    }
}
