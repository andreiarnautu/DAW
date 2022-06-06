using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressDetail { get; set; }

        public Author AssignedAuthor { get; set; }
    }
}
