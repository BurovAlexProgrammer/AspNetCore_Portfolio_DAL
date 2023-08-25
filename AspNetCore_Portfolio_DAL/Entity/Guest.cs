using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebDAL.Entity
{
    //[Table("Guests")]
    public class Guest
    {
        public Int64 id { get; set; }

        [Required] //NOT_NULL
        [MinLength(2)]
        [MaxLength(20)]
        public string name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string password { get; set; }

        public bool checkIt;
    }
}