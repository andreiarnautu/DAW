using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Entities
{
    public class Author
    {
        public int AuthorID { get; set; }

        public int AddressID { get; set; }

        public int BirthYear { get; set; }

        public int DeathYear { get; set; }

        public Address AssignedAddress { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
