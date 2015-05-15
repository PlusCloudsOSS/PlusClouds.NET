namespace PlusClouds.Net.Request.Users
{
    public class UserCreateRequest : AccessTokenizedRequest
    {
        public string AccountType { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}