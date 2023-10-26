using System;
using System.ComponentModel.DataAnnotations;

namespace WebDAL.Entities
{
    //[Table("Accounts")]
    public class Account
    {
        public Int64 id { get; set; }
        
        public string email { get; set; }
        
        public string phone { get; set; }
        public string name { get; set; }
        
        public string password { get; set; }
        
        public string token { get; set; }
    }
}