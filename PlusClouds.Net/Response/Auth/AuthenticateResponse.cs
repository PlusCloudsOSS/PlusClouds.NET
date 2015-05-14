namespace PlusClouds.Net.Response.Auth
{
    public class AuthenticateResponse : BaseResponse
    {
        public string SessionId { get; set; }
        public string AccessToken { get; set; }
        public string Expires { get; set; }
        public int LifeTime { get; set; }
        public int Remaining { get; set; }
    }
}