using PlusClouds.Net.Request.Products;
using PlusClouds.Net.Response.Products;
using PlusClouds.Net.Response.Users;
using RestSharp;

namespace PlusClouds.Net.Resources
{
    public class Products : BaseResource
    {
        private const string products = "products";

        public Products(PlusClouds plusClouds)
            : base(plusClouds)
        {
        }

        internal UserAuthenticateResponse UserAuthenticateResponse { get; set; }

        public ProductsListResponse List(ProductsListRequest productsListRequest)
        {
            return PlusClouds.Execute<ProductsListResponse>(products, Method.GET, productsListRequest);
        }
    }
}