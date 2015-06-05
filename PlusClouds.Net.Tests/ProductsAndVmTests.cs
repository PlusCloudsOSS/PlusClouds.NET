using System.Linq;
using PlusCloudsNet.Request.Products;
using PlusCloudsNet.Request.Users;
using PlusCloudsNet.Request.Vm;
using Xunit;

namespace PlusCloudsNet.Tests
{
    public class ProductsAndVmTests
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

        [Fact]
        public void PurchaseTrialProductTest()
        {
            var client = Utility.GetAuthenticatedClient();

            var userSession = client.Users.Authenticate(new UserAuthenticateRequest
            {
                Email = Utility.UserEmail,
                Password = Utility.UserPassword
            });

            var trialProduct = client.Products.List(new ProductsListRequest
            {
                Limit = 300
            }).Products.LastOrDefault(s => s.Value.Trial_Time != null).Value;

            if (trialProduct == null) return;

            client.Products.Free(new PurchaseProductRequest
            {
                SessionId = userSession.Session.Id,
                ProductId = trialProduct.Id
            });

            var response = client.Products.ListPurchasedProducts(new PurchasedProductsRequest
            {
                SessionId = userSession.Session.Id
            });

            if (response.ErrorMessage != "Satın alınmış ürün bulunamadı.") return;

            Assert.True(response.Result, response.ErrorMessage);
            Assert.NotNull(response.Products);
            Assert.NotNull(response.Products.Any(s => s.Value.Id == trialProduct.Id));
        }

        [Fact]
        public void PurchasedVmListTest()
        {
            var client = Utility.GetAuthenticatedClient();

            var userSession = client.Users.Authenticate(new UserAuthenticateRequest
            {
                Email = Utility.UserEmail,
                Password = Utility.UserPassword
            });

            var response = client.Vm.List(new VmListRequest
            {
                SessionId = userSession.Session.Id
            });


            Assert.True(response.Result, response.ErrorMessage);
            Assert.NotNull(response.Servers);
        }
    }
}