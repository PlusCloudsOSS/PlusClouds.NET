using System;

namespace PlusCloudsNet.Response.Auth
{
    public class AuthenticateResponse : BaseResponse
    {
        public string SessionId { get; set; }
        public string AccessToken { get; set; }
        public Int64 Expires { get; set; }
        public int LifeTime { get; set; }
        public int Remaining { get; set; }
    }
}