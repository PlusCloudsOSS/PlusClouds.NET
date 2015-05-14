using PlusClouds.Net.Request.Users;
using Xunit;

namespace PlusClouds.Net.Tests
{
    public class UsersTests
    {
        [Fact]
        public void Authneticate()
        {
            var client = Utility.GetAuthenticatedClient();
            var userData = client.Users.Authenticate(new UserAuthenticateRequest
            {
                Email = Utility.UserEmail,
                Password = Utility.UserPassword
            });

            Assert.True(userData.Result);
            client.Auth.Destroy();
        }

        [Fact]
        public void AuthneticatedUserSession()
        {
            var client = Utility.GetAuthenticatedClient();
            var userData = client.Users.Authenticate(new UserAuthenticateRequest
            {
                Email = Utility.UserEmail,
                Password = Utility.UserPassword
            });

            var session = client.Users.GetSession(userData.Session.Id);
            Assert.True(session.Result);
            client.Auth.Destroy();
        }
    }
}