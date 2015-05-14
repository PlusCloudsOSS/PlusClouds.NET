using System;
using PlusClouds.Net.Exceptions;
using PlusClouds.Net.Request;

namespace PlusClouds.Net
{
    public class PlusCloudsConfig : IAuthenticateRequest
    {
        public PlusCloudsConfig()
        {
            DateTimeFormat = "dd.MM.yyyy hh:mm:ss";
            NumberFormat = "##.000";
            ServerUri = new Uri("https://api.v1.plusclouds.com/");
        }

        public string DateTimeFormat { get; set; }
        public string NumberFormat { get; set; }
        public Uri ServerUri { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }

        public bool IsValid()
        {
            return string.IsNullOrEmpty(ClientId) &&
                   string.IsNullOrEmpty(ClientSecret) &&
                   ServerUri != null;
        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(ClientId) && string.IsNullOrEmpty(ClientSecret))
                throw new PlusConfigInvalidException("Invalid Config", "Config.ClientId, Config.ClientSecret");

            if (string.IsNullOrEmpty(ClientId))
                throw new PlusConfigInvalidException("Invalid Config", "Config.ClientId");

            if (string.IsNullOrEmpty(ClientSecret))
                throw new PlusConfigInvalidException("Invalid Config", "Config.ClientSecret");
        }
    }
}