using PlusCloudsNet.Request.Auth;
using PlusCloudsNet.Response.Auth;
using RestSharp;

namespace PlusCloudsNet.Resources
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
            AuthenticateResponse = PlusClouds.Execute<AuthenticateResponse>(authenticate, Method.POST,
                new AuthenticateRequest
                {
                    ClientId = PlusClouds.Config.ClientId,
                    ClientSecret = PlusClouds.Config.ClientSecret
                });

            return AuthenticateResponse;
        }

        public AuthenticateResponse AccessToken()
        {
            return PlusClouds.Execute<AuthenticateResponse>(accessToken, Method.GET);
        }

        public bool Destroy()
        {
            return PlusClouds.Execute(destroy).ResponseStatus == ResponseStatus.Completed;
        }
    }
}