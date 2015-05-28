using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
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
    }
}