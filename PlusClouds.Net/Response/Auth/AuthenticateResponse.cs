using PlusCloudsNet.Request;

namespace PlusCloudsNet.Response.Auth
{
    public class AuthenticateResponse : BaseResponse, IAuthResponse, IUserSessionRequest
    {
        public string AccessToken { get; set; }
        public long Expires { get; set; }
        public int LifeTime { get; set; }
        public int Remaining { get; set; }
        public string SessionId { get; set; }
    }
}