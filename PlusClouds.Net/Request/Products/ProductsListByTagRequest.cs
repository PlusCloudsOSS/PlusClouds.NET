namespace PlusCloudsNet.Request.Products
{
    public class ProductsListByTagRequest : BaseProductRequest, IPaginationRequest
    {
        public virtual string Category { get; set; }
        public virtual int DatacenterId { get; set; }
        public int Page { get; set; }
    }
}