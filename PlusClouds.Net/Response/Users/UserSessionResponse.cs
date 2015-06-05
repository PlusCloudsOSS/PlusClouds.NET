using PlusCloudsNet.Models;

namespace PlusCloudsNet.Response.Users
{
    public class UserSessionResponse : BaseResponse, IAuthResponse
    {
        public UserSession Session { get; set; }
    }
}