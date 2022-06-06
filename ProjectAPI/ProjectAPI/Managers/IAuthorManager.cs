using ProjectAPI.Entities;
using ProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Managers
{
    public interface IAuthorManager
    {
        public void Create(AuthorModel model);
        public void Update(AuthorModel model);
        public List<Author> GetAuthors();
        public Author GetAuthorById(int id);
        public void Delete(int id);
    }
}
