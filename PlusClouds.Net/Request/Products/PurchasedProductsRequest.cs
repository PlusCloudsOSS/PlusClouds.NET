using PlusCloudsNet.Attributes;

namespace PlusCloudsNet.Request.Products
{
    public class PurchasedProductsRequest : AccessTokenizedRequest, IPaginationRequest, IUserSessionRequest
    {
        public string ProductType { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }

        [Name("sid")]
        public string SessionId { get; set; }
    }
}