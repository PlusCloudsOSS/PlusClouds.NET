namespace PlusCloudsNet.Response.Auth
{
    public class AuthenticateResponse : BaseResponse
    {
        public string SessionId { get; set; }
        public string AccessToken { get; set; }
        public string Expires { get; set; }
        public string LifeTime { get; set; }
        public int Remaining { get; set; }
    }
}