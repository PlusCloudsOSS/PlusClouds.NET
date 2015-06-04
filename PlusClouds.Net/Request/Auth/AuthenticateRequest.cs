namespace PlusCloudsNet.Request.Auth
{
    public class AuthenticateRequest : IAuthenticateRequest, IRequest
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}