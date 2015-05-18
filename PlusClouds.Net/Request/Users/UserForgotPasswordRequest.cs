namespace PlusClouds.Net.Request.Users
{
    public class UserForgotPasswordRequest : AccessTokenizedRequest
    {
        public string Email { get; set; }
    }
}