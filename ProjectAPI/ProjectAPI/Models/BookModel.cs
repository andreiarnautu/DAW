using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class BookModel
    {
        [Key]
        public int BookID { get; set; }

        public int AuthorID { get; set; }

        public string BookName { get; set; }
    }
}
