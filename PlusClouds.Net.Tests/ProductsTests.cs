using System.Linq;
using PlusClouds.Net.Request.Products;
using PlusClouds.Net.Request.Users;
using Xunit;

namespace PlusClouds.Net.Tests
{
    public class ProductsTests
    {
        [Fact]
        public void ProductListTest()
        {
            var client = Utility.GetAuthenticatedClient();
            var userAuth = client.Users.Authenticate(new UserAuthenticateRequest
            {
                Email = Utility.UserEmail,
                Password = Utility.UserPassword
            });

            var response = client.Products.List(new ProductsListRequest
            {
                Limit = 10
            });

            Assert.True(response.Result);
            Assert.NotNull(response.Products);
            Assert.NotNull(response.Products.First().Value.Id);
        }

        [Fact]
        public void ProductListByTagTests()
        {
            var client = Utility.GetAuthenticatedClient();
            var userAuth = client.Users.Authenticate(new UserAuthenticateRequest
            {
                Email = Utility.UserEmail,
                Password = Utility.UserPassword
            });

            var response = client.Products.ListProductsByTag(new ProductsListByTagRequest
            {
                Category = "1",
                Page = 1,
                Limit = 10
            });

            Assert.True(response.Result);
            Assert.NotNull(response.Products);
            Assert.NotNull(response.Products.First().Value.Id);
        }
    }
}