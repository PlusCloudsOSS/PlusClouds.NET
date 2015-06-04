using System;
using System.Configuration;
using System.IO;

namespace PlusCloudsNet.Tests
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

        public static bool AllowUserCreate
        {
            get
            {
                return ConfigurationManager.AppSettings["AllowUserCreate"].Equals(bool.TrueString,
                    StringComparison.OrdinalIgnoreCase);
            }
        }

        public static PlusClouds GetAuthenticatedClient()
        {
            var client = new PlusClouds(ClientId, ClientSecret);
            client.Auth.Authenticate();

            return client;
        }

        public static void Dump(params string[] prm)
        {
            var path = Path.Combine(Directory.GetDirectoryRoot(Directory.GetCurrentDirectory())) +
                       string.Format("{0}.txt", Guid.NewGuid().ToString("N").Substring(15) + DateTime.Now.Ticks);

            using (var sw = new StreamWriter(path, true))
            {
                foreach (var val in prm)
                {
                    sw.WriteLine(val);
                }
            }
        }
    }
}