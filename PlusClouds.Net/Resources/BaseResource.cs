namespace PlusClouds.Net.Resources
{
    public abstract class BaseResource
    {
        protected BaseResource(PlusClouds plusClouds)
        {
            PlusClouds = plusClouds;
        }

        internal string AccessToken
        {
            get
            {
                if (PlusClouds.Auth.LastAuthResponse == null ||
                    PlusClouds.Auth.LastAuthResponse.Data == null ||
                    PlusClouds.Auth.LastAuthResponse.Data.Response == null)
                    return string.Empty;

                return PlusClouds.Auth.LastAuthResponse.Data.Response.AccessToken;
            }
        }

        internal PlusClouds PlusClouds { get; set; }
    }
}