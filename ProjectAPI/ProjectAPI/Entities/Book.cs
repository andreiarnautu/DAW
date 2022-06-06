using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Entities
{
    public class Book
    {
        public int BookID { get; set; }

        public int AuthorID { get; set; }

        public string BookName { get; set; }

        public Author AssignedAuthor { get; set; }
    }
}
