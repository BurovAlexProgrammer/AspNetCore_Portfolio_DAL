using System;
using System.ComponentModel.DataAnnotations;

namespace WebDAL.Models
{
    //[Table("Accounts")]
    public class Account
    {
        public Int64 id { get; set; }
        
        public string name { get; set; }
        
        public string password { get; set; }
        
        public string token { get; set; }
    }
}