namespace PlusCloudsNet.Request.Auth
{
    public interface IAuthenticateRequest
    {
        string ClientId { get; set; }
        string ClientSecret { get; set; }
    }
}