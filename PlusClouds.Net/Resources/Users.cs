using System;
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
            return PlusClouds.ApiClient.Execute<PlusResponseParent<UserAuthenticateResponse>>(
                new RestRequest(authenticate, Method.POST)
                    .AddParameter(new Parameter
                    {
                        Name = "accessToken",
                        Type = ParameterType.GetOrPost,
                        Value = AccessToken
                    })
                    .AddParameter(new Parameter
                    {
                        Name = "email",
                        Type = ParameterType.GetOrPost,
                        Value = userAuthenticateRequest.Email
                    })
                    .AddParameter(new Parameter
                    {
                        Name = "password",
                        Type = ParameterType.GetOrPost,
                        Value = userAuthenticateRequest.Password
                    })).Data.Response;
        }

        public UserSessionResponse GetSession(string sid)
        {
            return PlusClouds.ApiClient.Execute<PlusResponseParent<UserSessionResponse>>(new RestRequest(getSession, Method.GET)
                .AddParameter(new Parameter
                {
                    Name = "accessToken",
                    Type = ParameterType.GetOrPost,
                    Value = AccessToken
                })
                .AddParameter(new Parameter
                {
                    Name = "sid",
                    Type = ParameterType.GetOrPost,
                    Value = sid
                })).Data.Response;
        }
    }
}