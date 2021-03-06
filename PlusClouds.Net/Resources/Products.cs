using PlusCloudsNet.Request.Products;
using PlusCloudsNet.Response.Products;
using RestSharp;

namespace PlusCloudsNet.Resources
{
    public class Products : BaseResource
    {
        private const string products = "products";
        private const string productsByTag = "products/get-products-by-tag";
        private const string similarProducts = "products/get-similar-products";
        private const string purchasedProducts = "products/get-purchased-products";
        private const string productsBuy = "products/buy";
        private const string productsFree = "products/free";

        public Products(PlusClouds plusClouds)
            : base(plusClouds)
        {
        }

        public ProductsListResponse List(ProductsListRequest productsListRequest)
        {
            return PlusClouds.Execute<ProductsListResponse>(products, Method.GET, productsListRequest);
        }

        public ProductsListResponse ListProductsByTag(ProductsListByTagRequest productsListByTagRequest)
        {
            return PlusClouds.Execute<ProductsListResponse>(productsByTag, Method.GET, productsListByTagRequest);
        }

        public ProductsListResponse ListSimilarProducts(SimilarProductsRequest similarProductsRequest)
        {
            return PlusClouds.Execute<ProductsListResponse>(similarProducts, Method.GET, similarProductsRequest);
        }

        public ProductsListResponse ListPurchasedProducts(PurchasedProductsRequest purchasedProductsRequest)
        {
            return PlusClouds.Execute<ProductsListResponse>(purchasedProducts, Method.GET, purchasedProductsRequest);
        }

        public PurchaseProductResponse Buy(PurchaseProductRequest purchaseProductRequest)
        {
            return PlusClouds.Execute<PurchaseProductResponse>(productsBuy, Method.GET, purchaseProductRequest);
        }

        public PurchaseProductResponse Free(PurchaseProductRequest purchaseProductRequest)
        {
            return PlusClouds.Execute<PurchaseProductResponse>(productsFree, Method.GET, purchaseProductRequest);
        }
    }
}