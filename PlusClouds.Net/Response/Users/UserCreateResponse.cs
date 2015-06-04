namespace PlusCloudsNet.Response.Users
{
    public class UserCreateResponse : BaseResponse
    {
        public long Id { get; set; }
        public string ActivationCode { get; set; }
    }
}