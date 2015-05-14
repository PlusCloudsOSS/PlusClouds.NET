namespace PlusClouds.Net.Request.Auth
{
    public class AuthenticateRequest : IAuthenticateRequest
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}