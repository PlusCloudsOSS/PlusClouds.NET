namespace PlusClouds.Net.Response
{
    public class UserAuthenticateResponse : BaseResponse
    {
        public UserDefinition User { get; set; }
        public UserSession Session { get; set; }
    }
}