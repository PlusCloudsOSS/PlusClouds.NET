namespace PlusCloudsNet.Request.Products
{
    public class BaseProductRequest : AccessTokenizedRequest
    {
        public virtual int CountryId { get; set; }
        public int Limit { get; set; }
    }
}