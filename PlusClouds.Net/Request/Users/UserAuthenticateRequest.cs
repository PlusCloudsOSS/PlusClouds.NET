namespace PlusClouds.Net.Request.Users
{
    public class UserAuthenticateRequest : AccessTokenizedRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}