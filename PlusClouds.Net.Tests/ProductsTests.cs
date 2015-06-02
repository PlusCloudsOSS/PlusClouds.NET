using System.Linq;
using PlusClouds.Net.Request.Products;
using Xunit;

namespace PlusClouds.Net.Tests
{
    public class ProductsTests
    {
        [Fact]
        public void ProductListTest()
        {
            var client = Utility.GetAuthenticatedClient();

            var response = client.Products.List(new ProductsListRequest
            {
                Limit = 10
            });

            Assert.True(response.Result, response.ErrorMessage);
            Assert.NotNull(response.Products);
            Assert.NotNull(response.Products.First().Value.Id);
        }

        [Fact]
        public void ProductListByTagTests()
        {
            var client = Utility.GetAuthenticatedClient();

            var response = client.Products.ListProductsByTag(new ProductsListByTagRequest
            {
                Category = "1",
                Page = 1,
                Limit = 10
            });

            Assert.True(response.Result, response.ErrorMessage);
            Assert.NotNull(response.Products);
            Assert.NotNull(response.Products.First().Value.Id);
        }

        [Fact]
        public void SimilarProductsList()
        {
            var client = Utility.GetAuthenticatedClient();

            var response = client.Products.ListSimilarProducts(new SimilarProductsRequest
            {
                Id = 15
            });

            Assert.True(response.Result, response.ErrorMessage);
            Assert.NotNull(response.Products);
            Assert.NotNull(response.Products.First().Value.Id);
        }
    }
}