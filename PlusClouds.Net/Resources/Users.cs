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
        private const string activate = "users/activate";

        public Users(PlusClouds plusClouds) : base(plusClouds)
        {
        }

        public UserAuthenticateResponse Authenticate(UserAuthenticateRequest userAuthenticateRequest)
        {
            return PlusClouds.Execute<UserAuthenticateResponse>(authenticate, Method.POST, userAuthenticateRequest);
        }

        public UserSessionResponse GetSession(UserGetSessionRequest userGetSessionRequest)
        {
            return PlusClouds.Execute<UserSessionResponse>(getSession, Method.GET, userGetSessionRequest);
        }

        public bool DestroySession()
        {
            return PlusClouds.Execute(destroySession, Method.GET).ResponseStatus == ResponseStatus.Completed;
        }

        public UserCreateResponse Create(UserCreateRequest userCreateRequest)
        {
            return PlusClouds.Execute<UserCreateResponse>(create, Method.POST, userCreateRequest);
        }

        public UserActivationResponse Activate(UserActivationRequest userActivationRequest)
        {
            return PlusClouds.Execute<UserActivationResponse>(activate, Method.POST, userActivationRequest);
        }
    }
}