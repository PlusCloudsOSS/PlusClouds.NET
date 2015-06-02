namespace PlusClouds.Net.Request.Products
{
    public class ProductsListByTagRequest : AccessTokenizedRequest, IPaginationRequest
    {
        public virtual string Category { get; set; }
        public virtual string CountryId { get; set; }
        public int DatacenterId { get; set; }
        public int Page { get; set; }
        public int Limit { get; set; }
    }
}