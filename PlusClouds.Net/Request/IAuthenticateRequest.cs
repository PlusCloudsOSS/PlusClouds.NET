namespace PlusClouds.Net.Request
{
    public interface IAuthenticateRequest
    {
        string ClientId { get; set; }
        string ClientSecret { get; set; }
    }
}