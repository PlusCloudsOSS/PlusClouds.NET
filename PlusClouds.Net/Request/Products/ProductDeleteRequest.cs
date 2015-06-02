using PlusClouds.Net.Attributes;

namespace PlusClouds.Net.Request.Products
{
    public class ProductDeleteRequest : AccessTokenizedRequest
    {
        [Name("sid")]
        public string SessionId { get; set; }

        public int ServiceId { get; set; }
        public bool ForceStop { get; set; }
    }
}