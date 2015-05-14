using PlusClouds.Net.Request.Users;
using PlusClouds.Net.Response.Users;
using RestSharp;

namespace PlusClouds.Net.Resources
{
    public class Users : BaseResource
    {
        private const string authenticate = "users/authenticate";
        private const string getSession = "users/get-session";
        private const string create = "users/create";
        private const string destroySession = "users/destroy-session";

        public Users(PlusClouds plusClouds) : base(plusClouds)
        {
        }

        public UserAuthenticateResponse Authenticate(UserAuthenticateRequest userAuthenticateRequest)
        {
            userAuthenticateRequest.AccessToken = AuthenticateResponse.AccessToken;
            return PlusClouds.ApiClient.Execute<UserAuthenticateResponse>(authenticate, Method.POST, userAuthenticateRequest);
        }

        public UserSessionResponse GetSession(UserGetSessionRequest userGetSessionRequest)
        {
            userGetSessionRequest.AccessToken = AuthenticateResponse.AccessToken;
            return PlusClouds.ApiClient.Execute<UserSessionResponse>(getSession, Method.GET, userGetSessionRequest);
        }

        public bool DestroySession()
        {
            return PlusClouds.ApiClient.Execute(destroySession, Method.GET).ResponseStatus == ResponseStatus.Completed;
        }

        public UserCreateResponse Create(UserCreateRequest userCreateRequest)
        {
            userCreateRequest.AccessToken = AuthenticateResponse.AccessToken;
            return PlusClouds.ApiClient.Execute<UserCreateResponse>(create, Method.POST, userCreateRequest);
        }
    }
}