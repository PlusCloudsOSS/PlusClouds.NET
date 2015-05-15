using PlusClouds.Net.Attributes;

namespace PlusClouds.Net.Request.Users
{
    public class UserGetSessionRequest : AccessTokenizedRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }
    }
}