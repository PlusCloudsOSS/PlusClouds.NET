using System.Configuration;

namespace PlusClouds.Net.Tests
{
    public static class Utility
    {
        public static string UserEmail
        {
            get { return ConfigurationManager.AppSettings["userEmail"]; }
        }

        public static string UserPassword
        {
            get { return ConfigurationManager.AppSettings["userPassword"]; }
        }

        public static string ClientId
        {
            get { return ConfigurationManager.AppSettings["ClientId"]; }
        }

        public static string ClientSecret
        {
            get { return ConfigurationManager.AppSettings["ClientSecret"]; }
        }

        public static PlusClouds GetAuthenticatedClient()
        {
            var client = new PlusClouds(ClientId, ClientSecret);
            client.Auth.Authenticate();

            return client;
        }
    }
}