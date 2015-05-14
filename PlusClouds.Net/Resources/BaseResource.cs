using PlusClouds.Net.Response.Auth;

namespace PlusClouds.Net.Resources
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