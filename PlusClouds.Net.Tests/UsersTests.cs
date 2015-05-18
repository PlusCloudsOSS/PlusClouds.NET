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

            var session = client.Users.GetSession(new UserGetSessionRequest {SessionId = userData.Session.Id});
            Assert.True(session.Result);

            var updateRequest = ((UserUpdateRequest) userData.User);
            updateRequest.Address = Guid.NewGuid().ToString("N");
            updateRequest.SessionId = session.Session.Id;

            var updateResponse = client.Users.Update(updateRequest);
            Assert.True(updateResponse.Result);
            Assert.Equal(1, updateResponse.RowsAffected);

            userData = client.Users.Authenticate(new UserAuthenticateRequest
            {
                Email = Utility.UserEmail,
                Password = Utility.UserPassword
            });

            Assert.Equal(updateRequest.Address, userData.User.Address);

            Assert.True(client.Auth.Destroy());
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

            var userSession = client.Users.Authenticate(new UserAuthenticateRequest
            {
                Email = user.Email,
                Password = user.Password
            });

            var newPassword = Guid.NewGuid().ToString("N").Substring(0, 12);

            var passwordUpdateRequest = client.Users.ChangePassword(new UserChangePasswordRequest
            {
                SessionId = userSession.Session.Id,
                OldPassword = user.Password,
                Password = newPassword,
                ConfirmPassword = newPassword
            });

            Assert.True(passwordUpdateRequest.Result);
            Assert.Equal(1, passwordUpdateRequest.RowsAffected);

            var forgotPasswordRequest = client.Users.ForgotPassword(new UserForgotPasswordRequest {Email = user.Email});
            Assert.True(forgotPasswordRequest.Result);
            Assert.Equal(1, forgotPasswordRequest.RowsAffected);

            // todo: confirm code for forgot password tests
        }
    }
}