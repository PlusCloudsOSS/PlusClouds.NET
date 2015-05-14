namespace PlusClouds.Net.Request
{
    public class AuthenticateRequest : IAuthenticateRequest
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}