using PlusClouds.Net.Models;

namespace PlusClouds.Net.Response.Users
{
    public class UserAuthenticateResponse : BaseResponse
    {
        public UserDefinition User { get; set; }
        public UserSession Session { get; set; }
    }
}