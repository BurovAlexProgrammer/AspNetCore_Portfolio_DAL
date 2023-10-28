using System;

namespace WebDAL.Entities
{
    //[Table("Accounts")]
    public class Account
    {
        public Guid id { get; set; }
        
        public string email { get; set; }
        
        public string phone { get; set; }
        
        public string name { get; set; }
        
        public string password { get; set; }
        
        public string token { get; set; }

        public string role { get; set; }
    }
}