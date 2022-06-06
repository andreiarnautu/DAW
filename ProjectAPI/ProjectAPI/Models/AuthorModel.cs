using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class AuthorModel
    {
        [Key]
        public int AuthorID { get; set; }

        public int AddressID { get; set; }

        public int BirthYear { get; set; }

        public int DeathYear { get; set; }
    }
}
