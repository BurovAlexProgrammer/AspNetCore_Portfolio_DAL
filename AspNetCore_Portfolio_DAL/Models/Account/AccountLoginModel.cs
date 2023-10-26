namespace WebDAL.Models
{
    public class AccountLoginModel
    {
        public string AccountIdentity { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}