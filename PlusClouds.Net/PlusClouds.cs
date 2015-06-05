using System.Net;
using PlusCloudsNet.Resources;
using PlusCloudsNet.Response.Auth;
using RestSharp;

namespace PlusCloudsNet
{
    public class PlusClouds
    {
        public delegate void BeforeExecuteDelegate(PlusClouds client, RestRequest request);

        public PlusClouds(PlusCloudsConfig config)
        {
            Config = config;
            CreateRestClient();
        }

        public PlusClouds(string clientId, string clientSecret, bool autoUpdateSession = false)
            : this(
                new PlusCloudsConfig
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret,
                    AutoUpdateSession = autoUpdateSession
                })
        {
        }

        internal PlusCloudsConfig Config { get; set; }
        internal RestClient ApiClient { get; set; }
        internal AuthenticateResponse AuthenticateResponse { get; set; }
        public Auth Auth { get; set; }
        public Users Users { get; set; }
        public Products Products { get; set; }
        public Vm Vm { get; set; }
        public event BeforeExecuteDelegate BeforeExecute;

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
            Vm = new Vm(this);
        }

        internal void OnBeforeExecute(RestRequest request)
        {
            var handler = BeforeExecute;
            if (handler != null) handler(this, request);
        }
    }
}