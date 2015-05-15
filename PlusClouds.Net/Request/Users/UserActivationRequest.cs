namespace PlusClouds.Net.Request.Users
{
    public class UserActivationRequest : AccessTokenizedRequest
    {
        public string Email { get; set; }
        public string Code { get; set; }
    }
}