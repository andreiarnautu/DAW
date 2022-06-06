using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAPI.Models
{
    public class AddressModel
    {
        [Key]
        public int AddressId { get; set; }
        
        [Column(TypeName = "nvarchar(100)")]
        public string AddressDetail { get; set; }
    }
}
