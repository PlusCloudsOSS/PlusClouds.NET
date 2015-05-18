namespace PlusClouds.Net.Request.Users
{
    public class UserForgotPasswordConfirmRequest : UserForgotPasswordRequest
    {
        public string Code { get; set; }
    }
}