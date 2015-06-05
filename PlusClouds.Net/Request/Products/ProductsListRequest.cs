using PlusCloudsNet.Request.Products.Enums;

namespace PlusCloudsNet.Request.Products
{
    public class ProductsListRequest : BaseProductRequest, IPaginationRequest
    {
        public int Id { get; set; }
        public string Ids { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public PaymentType PaymentType { get; set; }
        public ProductType ProductType { get; set; }
        public ResourceType ResourceType { get; set; }
        public int Memory { get; set; }
        public long VendorId { get; set; }
        public Distribution Distribution { get; set; }
        public virtual int DatacenterId { get; set; }
        public int Page { get; set; }
    }
}