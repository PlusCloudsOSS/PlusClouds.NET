﻿using System;
using PlusClouds.Net.Request.Users;
using RestSharp;
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

            var session = client.Users.GetSession(new UserGetSessionRequest {Sid = userData.Session.Id});
            Assert.True(session.Result);
            client.Auth.Destroy();
        }

        [Fact]
        public void UserCreate()
        {
            if (!Utility.AllowUserCreate) return;

            var client = Utility.GetAuthenticatedClient();
            var ticks = DateTime.Now.Ticks.ToString().Substring(10);

            var user = new UserCreateRequest
            {
                Name = "PlusClouds.Net" + ticks,
                Surname = ".Net Library",
                AccountType = "PERSONEL",
                Email = "PlusClouds" + ticks + "@vctor.net",
                Password = Guid.NewGuid().ToString("N").Substring(0, 12)
            };

            user.ConfirmPassword = user.Password;

            var createResponse = client.Users.Create(user);

            Utility.Dump(SimpleJson.SerializeObject(user), SimpleJson.SerializeObject(createResponse));
            Assert.True(createResponse.Result);


            var activation = client.Users.Activate(new UserActivationRequest
            {
                Email = user.Email,
                Code = createResponse.ActivationCode
            });

            Assert.True(activation.Result);
            Assert.Equal(1, activation.RowsAffected);
        }
    }
}