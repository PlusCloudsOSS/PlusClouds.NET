namespace PlusClouds.Net.Request.Users
{
    public class UserGetSessionRequest : AccessTokenizedRequest
    {
        public string Sid { get; set; }
    }
}