using PlusCloudsNet.Response.Auth;

namespace PlusCloudsNet.Resources
{
    public abstract class BaseResource
    {
        protected BaseResource(PlusClouds plusClouds)
        {
            PlusClouds = plusClouds;
        }

        internal AuthenticateResponse AuthenticateResponse
        {
            get { return PlusClouds.AuthenticateResponse; }
            set { PlusClouds.AuthenticateResponse = value; }
        }

        internal PlusClouds PlusClouds { get; set; }
    }
}