using System;
using System.ComponentModel.DataAnnotations;

namespace WebDAL.Entity
{
    //[Table("Accounts")]
    public class Account
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

        public string token { get; set; }
    }
}