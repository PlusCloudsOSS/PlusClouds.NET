using System.Net;
using PlusClouds.Net.Resources;
using PlusClouds.Net.Response.Auth;
using RestSharp;

namespace PlusClouds.Net
{
    public class PlusClouds
    {
        public PlusClouds(PlusCloudsConfig config)
        {
            Config = config;
            CreateRestClient();
        }

        public PlusClouds(string clientId, string clientSecret)
            : this(new PlusCloudsConfig {ClientId = clientId, ClientSecret = clientSecret})
        {
        }

        internal PlusCloudsConfig Config { get; set; }
        internal RestClient ApiClient { get; set; }
        internal AuthenticateResponse AuthenticateResponse { get; set; }
        public Auth Auth { get; set; }
        public Users Users { get; set; }
        public Products Products { get; set; }

        protected void CreateRestClient()
        {
            Config.Validate();
            ApiClient = new RestClient(Config.ServerUri)
            {
                CookieContainer = new CookieContainer()
            };

            Auth = new Auth(this);
            Users = new Users(this);
            Products = new Products(this);
        }
    }
}