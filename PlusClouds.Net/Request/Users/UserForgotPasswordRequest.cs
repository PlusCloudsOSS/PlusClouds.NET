namespace PlusCloudsNet.Request.Users
{
    public class UserForgotPasswordRequest : AccessTokenizedRequest
    {
        public string Email { get; set; }
    }
}