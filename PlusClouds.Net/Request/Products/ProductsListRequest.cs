
namespace PlusClouds.Net.Request.Products
{
    public class ProductsListRequest : AccessTokenizedRequest
    {
        public int Id { get; set; }
        public string Ids { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public PaymentType PaymentType { get; set; }
        public ProductType ProductType { get; set; }
        public ResourceType ResourceType { get; set; }
        public int Memory { get; set; }
        public int VendorId { get; set; }
        public int DatacenterId { get; set; }
        public Distribution Distribution { get; set; }
        public string Page { get; set; }
        public int Limit { get; set; }
    }
}