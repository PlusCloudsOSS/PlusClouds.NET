using PlusClouds.Net.Request.Products;
using PlusClouds.Net.Response.Products;
using RestSharp;

namespace PlusClouds.Net.Resources
{
    public class Products : BaseResource
    {
        private const string products = "products";
        private const string productsByTag = "products/get-products-by-tag";

        public Products(PlusClouds plusClouds)
            : base(plusClouds)
        {
        }

        public ProductsListResponse List(ProductsListRequest productsListRequest)
        {
            return PlusClouds.Execute<ProductsListResponse>(products, Method.GET, productsListRequest);
        }

        public ProductsListResponse ListProductsByTag(ProductsListByTagRequest productsListRequest)
        {
            return PlusClouds.Execute<ProductsListResponse>(productsByTag, Method.GET, productsListRequest);
        }
    }
}