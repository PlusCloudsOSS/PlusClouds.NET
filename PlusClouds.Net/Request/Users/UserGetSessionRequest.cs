namespace PlusClouds.Net.Request.Users
{
    public class UserGetSessionRequest : IRequest
    {
        internal string AccessToken { get; set; }
        public string Sid { get; set; }
    }
}