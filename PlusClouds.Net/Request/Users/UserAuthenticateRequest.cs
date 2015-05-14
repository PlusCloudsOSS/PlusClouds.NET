namespace PlusClouds.Net.Request.Users
{
    public class UserAuthenticateRequest : IRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}