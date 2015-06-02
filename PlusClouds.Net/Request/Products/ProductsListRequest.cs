using PlusClouds.Net.Request.Products.Enums;

namespace PlusClouds.Net.Request.Products
{
    public class ProductsListRequest : ProductsListByTagRequest
    {
        private new string Category { get; set; }
        private new string CountryId { get; set; }
        public int Id { get; set; }
        public string Ids { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public PaymentType PaymentType { get; set; }
        public ProductType ProductType { get; set; }
        public ResourceType ResourceType { get; set; }
        public int Memory { get; set; }
        public int VendorId { get; set; }
        public Distribution Distribution { get; set; }
    }
}