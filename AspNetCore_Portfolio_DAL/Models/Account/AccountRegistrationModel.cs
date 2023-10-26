namespace WebDAL.Models
{
    public class AccountRegistrationModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string PasswordRepeat { get; set; }
        public string ReturnUrl { get; set; }
    }
}