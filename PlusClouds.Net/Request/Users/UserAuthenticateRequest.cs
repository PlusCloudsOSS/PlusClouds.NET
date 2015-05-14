namespace PlusClouds.Net.Request.Users
{
    public class UserAuthenticateRequest : IRequest
    {
        internal string AccessToken { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}