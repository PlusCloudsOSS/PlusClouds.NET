using System.Collections.Generic;
using PlusClouds.Net.Request;
using PlusClouds.Net.Response;
using RestSharp;

namespace PlusClouds.Net.Resources
{
    public class Users : BaseResource
    {
        private const string authenticate = "users/authenticate";
        private const string getSession = "users/get-session";

        public Users(PlusClouds plusClouds) : base(plusClouds)
        {
        }

        public UserAuthenticateResponse Authenticate(UserAuthenticateRequest userAuthenticateRequest)
        {
            return PlusClouds.ApiClient.Execute<UserAuthenticateResponse>(authenticate, Method.POST,
                new KeyValuePair<string, object>("accessToken", base.AuthenticateResponse.AccessToken),
                new KeyValuePair<string, object>("email", userAuthenticateRequest.Email),
                new KeyValuePair<string, object>("password", userAuthenticateRequest.Password));
        }

        public UserSessionResponse GetSession(string sid)
        {
            return PlusClouds.ApiClient.Execute<UserSessionResponse>(getSession, Method.GET,
                new KeyValuePair<string, object>("accessToken", base.AuthenticateResponse.AccessToken),
                new KeyValuePair<string, object>("sid", sid));
        }
    }
}