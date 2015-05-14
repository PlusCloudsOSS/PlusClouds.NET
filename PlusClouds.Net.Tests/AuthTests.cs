using PlusClouds.Net.Exceptions;
using Xunit;

namespace PlusClouds.Net.Tests
{
    public class AuthTests
    {
        [Fact]
        public void AutheticateMustThrowPlusConfigInvalidException()
        {
            Assert.Throws(typeof (PlusConfigInvalidException),
                () => { new PlusClouds(string.Empty, string.Empty).Auth.Authenticate(); });
        }

        [Fact]
        public void AutheticateFailed()
        {
            Assert.False(new PlusClouds("asdf", "asdf").Auth.Authenticate().Result);
        }

        [Fact]
        public void AutheticateSuccess()
        {
            var client = new PlusClouds(Utility.ClientId, Utility.ClientSecret);
            var authenticated = client.Auth.Authenticate();
            Assert.True(authenticated.Result);

            var accessToken = client.Auth.AccessToken();
            Assert.True(accessToken.Result);
            Assert.Equal(authenticated.AccessToken, accessToken.AccessToken);
            Assert.Equal(authenticated.SessionId, accessToken.SessionId);

            Assert.True(client.Auth.Destroy());
        }
    }
}