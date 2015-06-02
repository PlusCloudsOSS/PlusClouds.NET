using PlusClouds.Net.Attributes;

namespace PlusClouds.Net.Request.Products
{
    public class PurchasedProductsRequest : AccessTokenizedRequest, IPaginationRequest
    {
        public string ProductType { get; set; }

        [Name("sid")]
        public string SessionId { get; set; }

        public int Page { get; set; }
        public int Limit { get; set; }
    }
}