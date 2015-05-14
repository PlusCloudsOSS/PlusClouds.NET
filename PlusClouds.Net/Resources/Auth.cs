using PlusClouds.Net.Response;
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

        public IRestResponse<PlusResponseParent<AuthenticateResponse>> LastAuthResponse { get; set; }

        public AuthenticateResponse Authenticate()
        {
            var response =
                PlusClouds.ApiClient.Execute<PlusResponseParent<AuthenticateResponse>>(new RestRequest(authenticate,
                    Method.POST)
                    .AddParameter(new Parameter
                    {
                        Name = "clientId",
                        Type = ParameterType.GetOrPost,
                        Value = PlusClouds.Config.ClientId
                    })
                    .AddParameter(new Parameter
                    {
                        Name = "clientSecret",
                        Type = ParameterType.GetOrPost,
                        Value = PlusClouds.Config.ClientSecret
                    }));

            LastAuthResponse = response;
            return response.Data.Response;
        }

        public AuthenticateResponse AccessToken()
        {
            var response =
                PlusClouds.ApiClient.Execute<PlusResponseParent<AuthenticateResponse>>(new RestRequest(accessToken,
                    Method.GET));
            LastAuthResponse = response;
            return response.Data.Response;
        }

        public bool Destroy()
        {
            return PlusClouds.ApiClient.Execute(new RestRequest(destroy, Method.POST)).ResponseStatus ==
                   ResponseStatus.Completed;
        }
    }
}