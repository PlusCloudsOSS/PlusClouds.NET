namespace PlusCloudsNet.Request
{
    public abstract class AccessTokenizedRequest : IRequest
    {
        internal string AccessToken { get; set; }
    }
}