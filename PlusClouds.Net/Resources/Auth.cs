using System.Collections.Generic;
using PlusClouds.Net.Response.Auth;
using RestSharp;

namespace PlusClouds.Net.Resources
{
    public class Auth : BaseResource
    {
        private const string authenticate = "auth/authenticate";
        private const string accessToken = "auth/access-token";
        private const string destroy = "auth/destroy";

        public Auth(PlusClouds plusClouds) : base(plusClouds)
        {
        }

        public AuthenticateResponse Authenticate()
        {
            AuthenticateResponse = PlusClouds.ApiClient.Execute<AuthenticateResponse>(authenticate, Method.POST,
                new KeyValuePair<string, object>("clientId", PlusClouds.Config.ClientId),
                new KeyValuePair<string, object>("clientSecret", PlusClouds.Config.ClientSecret));
            return AuthenticateResponse;
        }

        public AuthenticateResponse AccessToken()
        {
            return PlusClouds.ApiClient.Execute<AuthenticateResponse>(accessToken, Method.GET);
        }

        public bool Destroy()
        {
            return PlusClouds.ApiClient.Execute(destroy).ResponseStatus == ResponseStatus.Completed;
        }
    }
}