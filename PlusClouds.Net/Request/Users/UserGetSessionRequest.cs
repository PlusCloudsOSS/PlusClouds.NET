using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Users
{
    public class UserGetSessionRequest : AccessTokenizedRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }
    }
}