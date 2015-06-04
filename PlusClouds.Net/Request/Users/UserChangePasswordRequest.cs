using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Users
{
    public class UserChangePasswordRequest : AccessTokenizedRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }

        public string OldPassword { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}