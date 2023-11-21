using System;
using Microsoft.AspNetCore.Identity;

namespace WebDAL.Entities
{
    //[Table("Accounts")]
    public class Account : IdentityUser<Guid>
    {
        public string email { get; set; }
        
        public string phone { get; set; }
        
        public string name { get; set; }
        
        public string token { get; set; }

        public string role { get; set; }
    }
}