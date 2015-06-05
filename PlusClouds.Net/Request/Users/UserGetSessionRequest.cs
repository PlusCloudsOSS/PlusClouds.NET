using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Users
{
    public class UserGetSessionRequest : AccessTokenizedRequest, IUserSessionRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }
    }
}