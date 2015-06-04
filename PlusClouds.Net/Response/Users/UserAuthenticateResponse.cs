using PlusCloudsNet.Models;

namespace PlusCloudsNet.Response.Users
{
    public class UserAuthenticateResponse : BaseResponse
    {
        public UserDefinition User { get; set; }
        public UserSession Session { get; set; }
    }
}