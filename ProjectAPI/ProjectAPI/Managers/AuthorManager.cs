using ProjectAPI.Entities;
using ProjectAPI.Models;
using ProjectAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Managers
{
    public class AuthorManager : IAuthorManager
    {
        private readonly IAuthorRepository authorRepository;

        public AuthorManager(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public void Create(AuthorModel model)
        {

            var newAuthor = new Author
                {
                    AuthorID = model.AuthorID,
                    AddressID = model.AddressID,
                    BirthYear = model.BirthYear,
                    DeathYear = model.DeathYear,
                };

              authorRepository.Create(newAuthor);
        }

        public void Update(AuthorModel model)
        {
            var newAuthor = GetAuthorById(model.AuthorID);
 
            newAuthor.AddressID= model.AddressID;
            newAuthor.AuthorID = model.AuthorID;
            newAuthor.BirthYear = model.BirthYear;
            newAuthor.DeathYear = model.DeathYear;

            authorRepository.Update(newAuthor);
        }

        public List<Author> GetAuthors()
        {
            return authorRepository.GetAuthors().ToList();
        }

        public Author GetAuthorById(int id)
        {
            var author = authorRepository
                .GetAuthors()
                .Where(author => author.AuthorID == id)
                .FirstOrDefault();
            return author;
        }

        public void Delete(int id)
        {
            var Author = GetAuthorById(id);
            authorRepository.Delete(Author);
        }
    }
}
